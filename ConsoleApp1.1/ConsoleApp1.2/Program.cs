using System;

namespace App1
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            
            Console.WriteLine("Вводите числа, после пишите 0");

            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                numbers.Add(number);
            }

            int sum = 0;
            int product = 1;
            foreach (int number in numbers)
            {
                sum += number;
                product *= number;
            }

            float average = (float)sum / numbers.Count;

            Console.WriteLine($"Cумма всех элементов: {sum}");
            Console.WriteLine($"Произведение всех чисел: {product}");
            Console.WriteLine($"Среднее значение всех чисел: {average}");
        }
    }
}