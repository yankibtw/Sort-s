using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 5, 2, 0, 10 };

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - i - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        int temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                    }
                }
            }

            foreach (var i in myArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}
