//You are given a string s, and your task is to reverse the string.

//Examples:

//Input: s = "Geeks"
//Output: "skeeG"
//Input: s = "for"
//Output: "rof"
//Input: s = "a"
//Output: "a"

using System;
using System.Security.Policy;

namespace ReverseAString
{
    public class Program
    {
        public static string reverseString(string str)
        {
            string rev = "";
            for(int i = str.Length - 1;i>=0; i--)
            {
                rev += str[i];

            }
            return rev;
        }
        static void Main(string[] args)
        {
            string str = "Geeks";
            string result = Program.reverseString(str);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
