using System;

namespace algorithm_v2.sorting
{
    public class Sorters
    {
        public void InsertionSort(int[] arr)
        {
            int key;
            int j;
            int arrLength = arr.Length;

            for (int i = 1; i < arrLength; i++)
            {
                key = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }
                arr[j + 1] = key;
            }
        }

        public void MergeSort(int[] arr, int l, int r)
        {
            Console.WriteLine("Merge_Sort({0}, {1})", l, r);
            if (l < r)
            {
                int m = l + (r - l) / 2;

                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);

                Merge(arr, l, m, r);
            }
        }

        public void Merge(int[] arr, int l, int m, int r)
        {
            Console.WriteLine("");
            Console.WriteLine("Merge({0}, {1}, {2})", l, m, r);
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            Console.WriteLine("n1 = {0}, n2 = {1}", n1, n2);
            Console.WriteLine("");

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];

            Console.WriteLine("Array L");
            PrintArr(L);
            Console.WriteLine("");

            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];

            Console.WriteLine("Array R");
            PrintArr(R);
            Console.WriteLine("");

            i = 0;
            j = 0;
            k = l;

            Console.WriteLine("");
            Console.WriteLine("Comparing both Arrs");
            Console.WriteLine("");
            while (i < n1 && j < n2)
            {
                Console.WriteLine("L[i] = {0}, R[j] = {1}", L[i], R[j]);
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;

                Console.WriteLine("Arr = ");
                PrintArr(arr);
                Console.WriteLine("");
                Console.WriteLine("i = {0}, j = {1}, k = {2}", i, j, k);
            }

            Console.WriteLine("");
            Console.WriteLine("Appending data left in L and R");
            while (i < n1)
            {
                Console.WriteLine("i = {0}, n1 = {1}", i, n1);
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                Console.WriteLine("j = {0}, n2 = {1}", j, n2);
                arr[k] = R[j];
                j++;
                k++;
            }

            Console.WriteLine("Arr = ");
            PrintArr(arr);
            Console.WriteLine("");
            Console.WriteLine("--------Merge Ops Ended------");
        }

        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, (i + 1), high);
            return (i + 1);
        }

        public void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        public void HeapSort(int[] arr, int n)
        {
            Console.WriteLine("HeapSort (arr, {0})", n);
            Console.Write("Arr ");
            PrintArr(arr);
            Console.WriteLine("");
            for (int i = n / 2 - 1; i >= 0; i--){
                Console.WriteLine("i = {0}", i);
                Heapify(arr, n, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                Heapify(arr, i, 0);
            }
        }

        public void Heapify(int[] arr, int n, int i)
        {
            Console.WriteLine("Heapify(arr, {0}, {1})", n, i);
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            Console.WriteLine("largest = {0}, left = {1}, right = {2}", largest, left, right);
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;

            Console.WriteLine("");
            PrintArr(arr);
            Console.WriteLine("");
            if (largest != i)
            {
                Swap(arr, i, largest);
                Console.WriteLine("On swapping");
                 PrintArr(arr);
                Console.WriteLine("");
                Heapify(arr, n, largest);
            }
        }

        public void Swap(int[] arr, int pos1, int pos2)
        {
            int temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
        }
        public void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}