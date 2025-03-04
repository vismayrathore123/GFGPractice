//Given two arrays a[] and b[], your task is to determine whether b[] is a subset of a[].

//Examples:

//Input: a[] = [11, 7, 1, 13, 21, 3, 7, 3], b[] = [11, 3, 7, 1, 7]
//Output: true
//Explanation: b[] is a subset of a[]
//Input: a[] = [1, 2, 3, 4, 4, 5, 6], b[] = [1, 2, 4]
//Output: true
//Explanation: b[] is a subset of a[]
//Input: a[] = [10, 5, 2, 23, 19], b[] = [19, 5, 3]
//Output: false
//Explanation: b[] is not a subset of a[]Given two arrays a[] and b[], your task is to determine whether b[] is a subset of a[].

//Examples:

//Input: a[] = [11, 7, 1, 13, 21, 3, 7, 3], b[] = [11, 3, 7, 1, 7]
//Output: true
//Explanation: b[] is a subset of a[]
//Input: a[] = [1, 2, 3, 4, 4, 5, 6], b[] = [1, 2, 4]
//Output: true
//Explanation: b[] is a subset of a[]
//Input: a[] = [10, 5, 2, 23, 19], b[] = [19, 5, 3]
//Output: false
//Explanation: b[] is not a subset of a[]

using System;

namespace ArraySubset
{
    public class Program
    {
        public static bool ArraySubset(int[] arr1, int[] arr2)
        {
            int count = 0;
            for (int i = 0; i < arr2.Length; i++) // Loop through arr2
            {
                bool found = false;
                for (int j = 0; j < arr1.Length; j++) // Loop through arr1
                {
                    if (arr2[i] == arr1[j])
                    {
                        found = true;
                        break; // Stop searching once found
                    }
                }
                if (!found)
                    return false; // If any element is not found, return false
            }
            return true; // All elements were found
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 11, 7, 1, 13, 21, 3, 7, 3 };
            int[] arr2 = { 11, 3, 7, 1, 7 };

            bool result = ArraySubset(arr1, arr2);
            Console.WriteLine(result ? "arr2 is a subset of arr1" : "arr2 is not a subset of arr1");
        }
    }
}
