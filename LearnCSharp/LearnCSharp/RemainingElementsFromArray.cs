using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;

namespace LearnCSharp
{
    public class RemainingElementsFromArray
    {
        public RemainingElementsFromArray()
        {
        }
        public static void printRemainingElements()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 1, 2, 4, 5, 6 };

            ArrayList alDups = new ArrayList();


        }

        public static void LongestSubSeq()
        {
            string abc = "ABCDfjkjgjgcAFG";
            string xyz = "ABDAFglja";
            List<char> list = xyz.ToCharArray().ToList();

            for (int i =0 ; i < abc.Length  ; i++)
            {
                if(list.Contains(abc[i]) && list.Count > 0)
                {
                    Console.Write(abc[i]);
                    list.Remove(abc[i]);
                }
            }
        }
    }
}
