using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            string path = (@"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.6\ConsoleApp6.2\numsTask2.txt");
            StreamReader readInput = new StreamReader(path);
            string words = readInput.ReadLine();
            
            while(words != null)
            {
                Console.Write(words + " ");

                words = readInput.ReadLine();
            }
        }
    }
}