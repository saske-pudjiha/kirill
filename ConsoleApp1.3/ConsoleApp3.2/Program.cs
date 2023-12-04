using System;
using System.IO;


namespace Program2
{
    class Program2
    {
        public static void Main()
        {
            string  input = @"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.3\ConsoleApp3.2\nums.txt";
            
            string[] pathInput = File.ReadAllLines(input);
            
            File.WriteAllText(input, string.Empty);
            
            string write = String.Empty;

            foreach (string elem in pathInput[0].Split(" "))
            {
                if (elem != "" && int.Parse(elem)% 2 != 0)
                {
                    write += elem + " ";
                    
                }
                
            }
            File.WriteAllText(input, write);
        }
    }
}
