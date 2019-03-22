using System;
using System.Collections.Generic;

namespace LearnCSharp
{
    public class Palindrome
    {
        public Palindrome()
        {
        }
        public bool IsPalindrome(string str)
        {
            for(int i=0, j = str.Length-1; i < j; i++, j--)
            {
                if(str[i] != str[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
