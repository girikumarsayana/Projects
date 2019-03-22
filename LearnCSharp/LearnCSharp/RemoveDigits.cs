using System;
namespace LearnCSharp
{
    public class RemoveDigits
    {
        public RemoveDigits()
        {
        }

        public void RemoveDigitsFromString()
        {
            string Mix = "1wf1ekh1kge14t834obj";
            string str = System.Text.RegularExpressions.Regex.Replace(Mix, @"[0-9]", "");
        }
    }
}
