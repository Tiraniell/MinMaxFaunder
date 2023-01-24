using System;

namespace MinMaxFaunder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Есть массив. Задача вывести исходны массив. Найти минимум и максимум. Найти среднее арифметическое

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            float arithmeticMean = 0f;

            int[] array = new int[] { 13, 3, 435, 5, 63, -7, 8, 9, 3, 6, 12 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }

                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            Console.WriteLine("Min " + minValue);
            Console.WriteLine("Max " + maxValue);

            for (int i = 0; i < array.Length; i++)
            {                
                int temporaryValue = array[i];
                arithmeticMean += (temporaryValue / array.Length);
            }

            Console.WriteLine("темп " + arithmeticMean);
        }

    }
}
