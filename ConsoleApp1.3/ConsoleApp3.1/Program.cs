using System;
using System.IO;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            string[] line = File.ReadAllLines(@"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.3\ConsoleApp3.1\input.txt");
            string[] chosenNumbers = line[0].Split(" ");
            int str = int.Parse(line[1]);
            
            List<string> result = new List<string>();

            for (int i = 0; i < str; i++)
            {
                string[] ticketNum = line[i + 2].Split(' ');
                int count = 0;

                foreach (string num1 in ticketNum)
                {
                    foreach (string num2 in chosenNumbers) 
                    {
                        if (num1 == num2)
                        {
                            count++;
                            break;
                        }
                    }
                }

                if (count >= 3)
                {
                    result.Add("Lucky");
                }
                else
                {
                    result.Add(("Unlucky"));
                }
            }
            File.WriteAllLines(@"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.3\ConsoleApp3.1\output.txt", result.ToArray());
        
        }
    }
}