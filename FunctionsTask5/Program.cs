using System;

namespace FunctionsTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minValue = 0;
            int maxValue = 101;
            int arraySize = 10;
            int[] array = new int[arraySize];

            FillArray(ref array, random, minValue, maxValue);

            Console.WriteLine("Массив: ");
            ShowArray(array);

            Shuffle(ref array, random, minValue);

            Console.WriteLine("Массив со случайно перемещенными элементами");
            ShowArray(array);
        }

        static void FillArray(ref int[] array, Random random, int minValue, int maxValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }

        static void Shuffle(ref int[] array, Random random, int minValue)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int newPosition = GetRandomPosition(i, random, minValue, array.Length);
                int temp = array[i];
                array[i] = array[newPosition];
                array[newPosition] = temp;
            }
        }

        static int GetRandomPosition(int index, Random random, int minValue, int maxValue)
        {
            int newPosition = index;

            while (newPosition == index)
            {
                newPosition = random.Next(minValue, maxValue);
            }

            return newPosition; 
        }

    }
}
