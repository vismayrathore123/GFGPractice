using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given an array arr[] where no two adjacent elements are same, find the index of a peak element. An element is considered to be a peak if it is greater than its adjacent elements (if they exist). If there are multiple peak elements, return index of any one of them. The output will be "true" if the index returned by your function is correct; otherwise, it will be "false".

//Note: Consider the element before the first element and the element after the last element to be negative infinity.
//    Examples :

//Input: arr = [1, 2, 4, 5, 7, 8, 3]
//Output: true
//Explanation: arr[5] = 8 is a peak element because arr[4] < arr[5] > arr[6].
//Input: arr = [10, 20, 15, 2, 23, 90, 80]
//Output: true
//Explanation: arr[1] = 20 and arr[5] = 90 are peak elements because arr[0] < arr[1] > arr[2] and arr[4] < arr[5] > arr[6]. 
//Input: arr = [1, 2, 3]
//Output: true
//Explanation: arr[2] is a peak element because arr[1] < arr[2] and arr[2] is the last element, so it has negative infinity to its right.Examples :

//Input: arr = [1, 2, 4, 5, 7, 8, 3]
//Output: true
//Explanation: arr[5] = 8 is a peak element because arr[4] < arr[5] > arr[6].
//Input: arr = [10, 20, 15, 2, 23, 90, 80]
//Output: true
//Explanation: arr[1] = 20 and arr[5] = 90 are peak elements because arr[0] < arr[1] > arr[2] and arr[4] < arr[5] > arr[6]. 
//Input: arr = [1, 2, 3]
//Output: true
//Explanation: arr[2] is a peak element because arr[1] < arr[2] and arr[2] is the last element, so it has negative infinity to its right.



namespace PeakElement
{
    public class Program
    {
        public static int FindPeakElement(int[] arr)
        {
            int n = arr.Length;

            if (n == 1) return 0; // If only one element, it's a peak

            for (int i = 0; i < n; i++)
            {
                if ((i == 0 || arr[i] > arr[i - 1]) &&
                    (i == n - 1 || arr[i] > arr[i + 1]))
                {
                    return i; // Return the index of a peak element
                }
            }

            return -1; // No peak found (shouldn't happen as per problem constraints)
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 7, 8, 3 };
            int peakIndex = FindPeakElement(arr);

            Console.WriteLine(peakIndex >= 0 &&
                              (peakIndex == 0 || arr[peakIndex] > arr[peakIndex - 1]) &&
                              (peakIndex == arr.Length - 1 || arr[peakIndex] > arr[peakIndex + 1])
                              ? "true" : "false");

            Console.ReadLine();
        }
    }
}

