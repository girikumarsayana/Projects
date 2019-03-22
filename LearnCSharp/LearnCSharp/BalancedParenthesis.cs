using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnCSharp
{
    public class BalancedParenthesis
    {
        public BalancedParenthesis()
        {
            bool str = IsBalanced("[]{(<>)}");
        }

        public static bool IsBalanced(string input)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                {'{','}'},
                {'[',']'},
                {'(',')'},
                {'<','>'}
            };

            Stack<char> brackets = new Stack<char>();

            try
            {
                foreach(char c in input)
                {
                    if (bracketPairs.ContainsKey(c))
                    {
                        brackets.Push(c);
                    }
                    else if (bracketPairs.ContainsValue(c))
                    {
                        if(c == bracketPairs[brackets.Peek()])
                        {
                            brackets.Pop();
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else { return false; }
                }
            }
            catch(Exception ex)
            {
                return false;
            }

            return brackets.Count() == 0 ? true : false;
        }
    }
}
