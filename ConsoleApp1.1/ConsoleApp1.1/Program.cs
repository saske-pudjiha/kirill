using System;

namespace App1
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
            }

            int minIndex = 0;
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"Минимальный номер элемента: {minIndex}");
        }
    }
}