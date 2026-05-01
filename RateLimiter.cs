using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class RateLimiter
    {
        private readonly int _limit;
        private readonly TimeSpan _window;

        private readonly ConcurrentDictionary<string, (int count, DateTime start)> _request = new ConcurrentDictionary<string, (int count, DateTime start)>();
        private readonly Dictionary<string, Queue<DateTime>> _responseTimes;

        public RateLimiter(int limit, TimeSpan window) 
        { 
            _limit = limit;
            _window = window;
            _responseTimes = new Dictionary<string, Queue<DateTime>>();

        }

        public bool AllowRequest(string userId)
        {
            var now = DateTime.UtcNow;
            var entry = _request.GetOrAdd(userId, (0, now));

            if(now - entry.start > _window)
            {
                entry = (0, now);
            }

            if(entry.count + 1 > _limit)
            {
                return false;
            }

            _request[userId] = (entry.count + 1, entry.start);
            return true;    
        }

        public bool AllowResponse(string userId)
        {

            if(!_responseTimes.ContainsKey(userId))
            {
                _responseTimes[userId] = new Queue<DateTime>();

                _responseTimes[userId].Enqueue(DateTime.UtcNow);
            }

            var now = DateTime.UtcNow;
            var requests = _responseTimes[userId];

            if(_responseTimes.Count> 0 && (now - requests.Peek() > _window))
            {
                requests.Dequeue();
            }

            if(requests.Count < _limit)
            {
                requests.Enqueue(now);
                return true;
            }

            return false;

        }


    }
}
