using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 10 == 0 && num % 2 == 0)
            {
                Console.WriteLine(num + " Число четное и кратое 10");
            }
            else
            {
                Console.WriteLine(" Число не четное и не кратное 10");
            }

        }
    }
}