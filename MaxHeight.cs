using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class Cube
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
    public static class MaxHeight
    {

        static MaxHeight()
        {
            var list = new List<Cube>
                {
                    new Cube { Length = 4, Width = 5, Height = 3},
                    new Cube { Length = 2, Width = 3, Height = 2},
                    new Cube { Length = 3, Width = 6, Height = 2},
                    new Cube { Length = 1, Width = 5, Height = 4},
                    new Cube { Length = 2, Width = 4, Height = 1},
                    new Cube { Length = 1, Width = 2, Height = 2}
                };
        }

        public static int FindMaxHeightOfCubes(List<Cube> cubes)
        {
            int n = cubes.Count;

            int[] dp = new int[n];
            Array.Fill(dp, 1);

            int[] mh = new int[n];

            for(int i = 0; i<n;i++)
            {
                mh[i] = cubes[i].Height;
            }

            for(int i = 1; i<n;i++)
            {
                for (int j = 0; j< i;j++)
                {
                    if ((cubes[j].Length > cubes[i].Length) 
                        && (cubes[j].Width > cubes[i].Width)
                        && dp[i] < Math.Max(dp[i], dp[j] + 1))
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                        mh[i] = Math.Max(mh[i], cubes[i].Height + mh[j]);
                    }
                }
            }

            return mh.Max();
        }

    }
}
