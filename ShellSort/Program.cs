using System;

namespace ShellSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 5, 2, 0, 10 };
            int n = myArray.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = myArray[i];
                    int j = i;

                    while (j >= gap && myArray[j - gap] > temp)
                    {
                        myArray[j] = myArray[j - gap];
                        j -= gap;
                    }

                    myArray[j] = temp;
                }

                gap /= 2;
            }

            foreach (var i in myArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
