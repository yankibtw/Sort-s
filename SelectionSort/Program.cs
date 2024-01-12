using System;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 5, 2, 0, 10 };
            int n = myArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (myArray[j] < myArray[minIndex])
                        minIndex = j;
                }

                if (minIndex != i)
                {
                    Swap(ref myArray[i], ref myArray[minIndex]);
                }
            }


            void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            foreach (var i in myArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
