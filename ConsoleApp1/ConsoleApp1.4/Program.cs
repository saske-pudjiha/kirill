using System;

namespace App1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите начало диапазона: ");
            int start = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Введите конец диапазона: ");
            int end = Convert.ToInt32(Console.ReadLine());

            int[] numbers = randomArray(start, end);

            Console.WriteLine("Сгенерированные числа:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        static int[] randomArray(int start, int end)
        {
            Random r = new Random();
            int size = 10; 
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = r.Next(start, end + 1); 
            }

            return array;
        }
    }    
}