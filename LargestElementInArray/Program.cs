using System;
using System.Xml.Linq;

//Given an array arr[]. The task is to find the largest element and return it.Given an array arr[]. The task is to find the largest element and return it.
//    Input: arr[] = [1, 8, 7, 56, 90]
//Output: 90
//Explanation: The largest element of the given array is 90.
//Input: arr[] = [5, 5, 5, 5]
//Output: 5
//Explanation: The largest element of the given array is 5.
//Input: arr[] = [10]
//Output: 10
//Explanation: There is only one element which is the largest.

namespace LargestElementInArray
{
    public class Program
    {
        public static int LargestElementInArray(int[] arr)
        {
            int largest = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            return largest;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 8, 7, 56, 90 };
            int result = Program.LargestElementInArray(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
