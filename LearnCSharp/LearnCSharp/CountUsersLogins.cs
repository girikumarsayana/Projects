using System;
using System.Collections.Generic;

namespace LearnCSharp
{
    public class CountUsersLogins
    {
        public CountUsersLogins()
        {
        }

        public static void stringChecker()
        {
            string[] input = new string[] { "user1", "user2", "user1", "user3", "user3" };

            Dictionary<string, int> set = new Dictionary<string, int>();
            foreach (string s in input)
            {
                if (set.ContainsKey(s))
                {
                    set[s]++;
                }
                else
                {
                    set.Add(s, 1);
                }
            }

            foreach (var s in set)
            {
                Console.WriteLine(s.Key + ":" + s.Value);
            }


        }
    }
}
