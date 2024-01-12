using System;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 5, 2, 0, 10 };

            int n = myArray.Length;
            int[] tempArray = new int[n];
            MergeSortRecursive(myArray, tempArray, 0, n - 1);

            foreach (var i in myArray)
            {
                Console.WriteLine(i);
            }
        }
        static void MergeSortRecursive(int[] array, int[] tempArray, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSortRecursive(array, tempArray, left, middle);
                MergeSortRecursive(array, tempArray, middle + 1, right);

                Merge(array, tempArray, left, middle, right);
            }
        }
        private static void Merge(int[] array, int[] tempArray, int left, int middle, int right)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            Array.Copy(array, left, leftArray, 0, leftSize);
            Array.Copy(array, middle + 1, rightArray, 0, rightSize);

            int i = 0, j = 0, k = left;

            while (i < leftSize && j < rightSize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftSize)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightSize)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
