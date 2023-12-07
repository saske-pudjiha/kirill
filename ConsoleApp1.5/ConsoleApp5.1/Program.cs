using System;

class Program
{
    static void Main()
    {
        string pathInput = (@"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.5\ConsoleApp5.1\numsTask1.txt");
        StreamReader readInput = new StreamReader(pathInput);
        string[] input = readInput.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int min = numbers[0];
        int minElement = 0;
        int multiplication = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
                minElement = i;
            }
        }

        for (int i = minElement + 1; i < numbers.Length; i++)
        {
            multiplication = multiplication * numbers[i];
        }

        Console.WriteLine(multiplication);
    }
}