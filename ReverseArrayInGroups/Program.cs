//Given an array arr of positive integers. Reverse every sub-array group of size k.

//Note: If at any instance, k is greater or equal to the array size, then reverse the entire array. You shouldn't return any array, modify the given array in place.

//Examples:

//Input: arr[] = [1, 2, 3, 4, 5], k = 3
//Output: [3, 2, 1, 5, 4]
//Explanation: First group consists of elements 1, 2, 3. Second group consists of 4,5.
//Input: arr[] = [5, 6, 8, 9], k = 5
//Output: [9, 8, 6, 5]
//Explnation: Since k is greater than array size, the entire array is reversed.Given an array arr of positive integers. Reverse every sub-array group of size k.

//Note: If at any instance, k is greater or equal to the array size, then reverse the entire array. You shouldn't return any array, modify the given array in place.

//Examples:

//Input: arr[] = [1, 2, 3, 4, 5], k = 3
//Output: [3, 2, 1, 5, 4]
//Explanation: First group consists of elements 1, 2, 3. Second group consists of 4,5.
//Input: arr[] = [5, 6, 8, 9], k = 5
//Output: [9, 8, 6, 5]
//Explnation: Since k is greater than array size, the entire array is reversed.

using System;
namespace ReverseArrayInGroups
{
    public class Program
    {
        public static void reverseArrayInGroups(int[] arr, int k)
        {
            int n = arr.Length;

            // If k is greater than or equal to the array size, reverse the entire array.
            if (k >= n)
            {
                Array.Reverse(arr);
                return;
            }

            // Process each sub-array of size k
            for (int i = 0; i < n; i += k)
            {
                int left = i;
                int right = Math.Min(i + k - 1, n - 1); // Ensure we don't go out of bounds

            
                while (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 3;

            reverseArrayInGroups(arr, k);

            Console.WriteLine("Reversed Array: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
           
        }
    }
}