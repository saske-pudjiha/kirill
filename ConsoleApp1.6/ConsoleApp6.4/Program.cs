using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            int a = 0;
            Console.WriteLine("Введите число a: ");
            int sum = 0;
            a = int.Parse(Console.ReadLine());
            int num;
            
            while (true)
            {
                Console.WriteLine("Вводите числа, когда хотите закончить пишите 0 или отрицательное число ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num <= 0)
                {
                    break;
                }

                if (num % a  == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine("Сумма = " + sum);
        }
    }
}