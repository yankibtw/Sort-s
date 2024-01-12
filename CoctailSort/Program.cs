using System;

namespace CoctailSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 5, 2, 0, 10 };

            int left = 0,
                right = myArray.Length - 1,
                qty = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    qty++;
                    if (myArray[i] > myArray[i + 1])
                    {
                        Swap(myArray, i, i + 1);
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    qty++;
                    if (myArray[i - 1] > myArray[i])
                        Swap(myArray, i - 1, i);
                }
                left++;
            }

            foreach (var i in myArray)
            {
                Console.WriteLine(i);
            }
        }
        static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }
    }
}
