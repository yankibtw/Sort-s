using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 5, 2, 0, 10 };
            QuickSortRecursive(myArray, 0, myArray.Length - 1);

            foreach (var i in myArray)
            {
                Console.WriteLine(i);
            }
        }

         static void QuickSortRecursive(int[] array, int left, int right)
        {
            if (left < right)
            {
                int partitionIndex = Partition(array, left, right);

                QuickSortRecursive(array, left, partitionIndex - 1);
                QuickSortRecursive(array, partitionIndex + 1, right);
            }
        }

         static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }

            Swap(ref array[i + 1], ref array[right]);
            return i + 1;
        }

         static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
