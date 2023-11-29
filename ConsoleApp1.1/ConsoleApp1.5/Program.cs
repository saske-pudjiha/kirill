using System;

namespace App1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вводите текст, разделяя их пробелом");
            string textUser = Console.ReadLine();
            int coutWord = 0;

            foreach (char chr in textUser)
            {
                if (chr == ' ')
                {
                    ++coutWord;
                }
            }

            ++coutWord;

            textUser = " Start "  + textUser + " End ";
            
            Console.WriteLine(coutWord);
            
            Console.WriteLine(textUser);
        }
    }    
}