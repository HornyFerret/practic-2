using System;

namespace Практика_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] xui = { 2, 2, 4, 4, 6, 6, 8, 8 };
            int[] arr2 = GetHalfArray(xui);
            ShowArr(arr2);
        }

        static int[] GetHalfArray(int[] arr)
        {
            if (arr.Length % 2 != 0) // Если массив имеет нечетное количество элементов, то вернуть пустой массив без элементов
                return new int[0];

            int halfArrayLenght = arr.Length / 2;
            int[] halfArray = new int[halfArrayLenght];

            for (int i = 0, j = 0; i < (arr.Length - 1); i +=2, j++)
            {
                halfArray[j] = ((arr[i] + arr[i + 1]) / 2);
            }

            return halfArray;
        }

        static void ShowArr(int[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr [" + i + "] = " + arr[i]);
            }
        }
    }
}
