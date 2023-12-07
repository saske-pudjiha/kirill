using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            string path = (@"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.6\ConsoleApp6.1\numsTask1.txt");
            StreamReader readInput = new StreamReader(path);
            string[] words = readInput.ReadLine().Split(" ");
            

            foreach (var word in words)
            {
                if (word.Length % 2 != 0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}