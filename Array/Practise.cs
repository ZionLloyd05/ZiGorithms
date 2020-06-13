using System;

namespace algorithm_v2.Array
{
    public class ArrPractise
    {
        public static void LeftRotate(int[] arr, int d, int n)
        {
            if (d == 0)
                return;

            ReverseArray(arr, 0, d - 1);
            ReverseArray(arr, d, n - 1);
            ReverseArray(arr, 0, n - 1);
        }

        private static void ReverseArray(int[] arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }

        /*UTILITY FUNCTIONS*/
        /* function to print an array */
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}