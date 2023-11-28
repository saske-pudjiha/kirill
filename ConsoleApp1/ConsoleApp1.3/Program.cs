using System;

namespace App1
{
    class Program
    {
        static void Main()
        {
            String[] array = new String[10000];
            Console.WriteLine("Введите число: ");
            String input = " ";
            int count = 0;

            do
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                array[count] = input;
                count++;
                
            } while (true);
        
            if (array.Length > 0)
            {
                String shortest = array[0];
                String longtest = array[0];

                foreach (String element in array)
                {
                    if (element == null)
                    {
                        break;
                    }
                    
                    if (element.Length < shortest.Length)
                        shortest = element;

                    if (element.Length > longtest.Length)
                        longtest = element;
                }

                Console.WriteLine("Самый короткий элемент: " + shortest);
                Console.WriteLine("Самый длинный элемент: " + longtest);
            }
            else
            {
                Console.WriteLine("Список пуст");
            }
        }
    }
}