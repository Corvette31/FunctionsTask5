using System;

namespace FunctionsTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxValue = 101;
            int arraySize = 10;
            int[] array = new int[arraySize];

            FillArray(array, random,  maxValue);

            Console.WriteLine("Массив: ");
            ShowArray(array);

            Shuffle(array, random);

            Console.WriteLine("Массив со случайно перемещенными элементами");
            ShowArray(array);
        }

        static void FillArray(int[] array, Random random, int maxValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(maxValue);
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

        static void Shuffle(int[] array, Random random)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int newPosition = random.Next(array.Length);
                int temp = array[i];
                array[i] = array[newPosition];
                array[newPosition] = temp;
            }
        }
    }
}
