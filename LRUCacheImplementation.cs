using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class LRUCacheImplementation
    {
        private Dictionary<int, LinkedListNode<(int key, int value)>> _cache;
        private readonly LinkedList<(int key, int value)> _lruList;
        private readonly int _capacity;

        public LRUCacheImplementation(int capacity)
        {
            _capacity = capacity;
            _cache = new Dictionary<int, LinkedListNode<(int key, int value)>>();
            _lruList = new LinkedList<(int key, int value)>();
        }


        public void Put(int key, int value)
        {
            Console.WriteLine($"Putting key: {key}, value: {value}");
            Console.WriteLine($"Cache at the time of putting: {string.Join(", ", _cache.Keys)}");
            Console.WriteLine($"LRU List at the time of putting: {string.Join(", ", _lruList)}");
            if (_cache.ContainsKey(key))
            {

                var node = _cache [key];
                _lruList.Remove(node);
                Console.WriteLine($"LRU List at the time of putting while key exist and remove from linklist: {string.Join(", ", _lruList)}");
            }
            else if(_cache.Count == _capacity)
            {
                Console.WriteLine($"LRU List at the time of putting while cache is full: {string.Join(", ", _lruList)}");
                var lru = _lruList.Last;
                
                _cache.Remove(lru.Value.key);
                Console.WriteLine($"Cache List at the time of remove while cache is full and remove the last from the Link list: {string.Join(", ", _cache.Keys)}");
                _lruList.RemoveLast();
                Console.WriteLine($"LRU List at the time of putting while cache is full and removed from last: {string.Join(", ", _lruList)}");
            }

            var newNode = new LinkedListNode<(int, int)>((key, value));
            _lruList.AddFirst(newNode);
            Console.WriteLine($"LRU List at the time of putting: {string.Join(", ", _lruList)}");
            _cache[key] = newNode;
            Console.WriteLine($"Cache List at the time of putting: {string.Join(", ", _cache.Keys)}");
            
        }

        public int Get(int key)
        {
            if(!_cache.ContainsKey(key))
            {
                return -1; // Not found
            }
            var node = _cache[key];
            _lruList.Remove(node);
            _lruList.AddFirst(node); // Move to front as it's recently used
            Console.WriteLine($"LRU List at the time of Getting: {string.Join(", ", _lruList)}");
            Console.WriteLine($"Cache List at the time of Getting: {string.Join(", ", _cache.Keys)}");
            return node.Value.value;
        }

    }
}
