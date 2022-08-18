using System;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            string s = "pwwkew";
            Console.WriteLine(program.LengthOfLongestSubstring(s));
        }

        private int LengthOfLongestSubstring(string s) {
            if (string.IsNullOrEmpty(s))
                return 0;

            HashSet<char> set = new HashSet<char>();
            int currentMax = 0,
                i = 0,
                j = 0;

            while (j < s.Length)
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    currentMax = Math.Max(currentMax, j - i);
                }
                else
                    set.Remove(s[i++]);

            return currentMax;
        }
    }
}