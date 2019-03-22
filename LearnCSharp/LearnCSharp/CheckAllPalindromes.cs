using System;
using System.Collections.Generic;

namespace LearnCSharp
{
    public class CheckAllPalindromes
    {
        public CheckAllPalindromes()
        {
        }

        public static bool CheckPalindromes(string inputString)
        {
            int n = inputString.Length;
            if (n == 1 )
            {
                return true;
            }

            for (int i=0, j=n-1; i<= n/2 && j>0; i++, j--)
            {
                if (inputString[i] != inputString[j])
                {
                    return false;
                }
               
            }
            return true;
        }

        public static void PrintAllPalindromes(string InputString)
        {
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < InputString.Length; i++)
            {
                for (int j = i; j < InputString.Length; j++)
                {
                    if (CheckPalindromes(InputString.Substring(i, j-i+1)))
                    {
                        set.Add(InputString.Substring(i, j-i+1));
                    }
                }
            }

            foreach(string str in set)
            {
                Console.WriteLine(str);
            }
        }
    }
}
