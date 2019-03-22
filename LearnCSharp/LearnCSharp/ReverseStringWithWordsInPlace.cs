using System;
namespace LearnCSharp
{
    public class ReverseStringWithWordsInPlace
    {
        public ReverseStringWithWordsInPlace()
        {
        }

        public static void ReverseInputArray()
        {
            char[] inputArray = { 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'e', 'r', 'f', 'e', 'c', 't' };

            ReversetheWholeString(inputArray);
            ReverseWords(inputArray);

            Console.WriteLine(inputArray);
        }

       
        private static void ReversetheWholeString(char[] inputArray)
        {
            ReversetheWholeString(inputArray, 0, inputArray.Length - 1);

        }

        private static void ReversetheWholeString(char[] inputArray, int f, int t)
        {
            for (int i = f, j = t; i < j; i++, j--)
            {
                char temp = inputArray[i];
                inputArray[i] = inputArray[j];
                inputArray[j] = temp;
            }
        }

        static void ReverseWords(char[] inputArray)
        {
            int wordhead ,wordtail;
            int current = 0;
            while(current < inputArray.Length)
            {
                wordhead = current;
                wordtail = IndexOf(inputArray, ' ', wordhead);
                if ( -1 == wordtail)
                {
                    ReversetheWholeString(inputArray, wordhead, inputArray.Length-1);
                    current = inputArray.Length;
                }
                else
                {
                    ReversetheWholeString(inputArray, wordhead, wordtail-1);
                    current = wordtail + 1;
                }
            }
        }

        private static int IndexOf(char[] inputArray, char character , int start)
        {
            for(int i = start; i< inputArray.Length-1; i++)
            {
                if(inputArray[i] == character)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
