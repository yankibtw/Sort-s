using System;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 5, 2, 0, 10 };

            for (int i = 1; i < myArray.Length; i++)
            {
                int k = myArray[i],
                    j = i - 1;

                while (j >= 0 && myArray[j] > k)
                {
                    myArray[j + 1] = myArray[j];
                    myArray[j] = k;
                    j--;
                }
            }

            foreach (var i in myArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
