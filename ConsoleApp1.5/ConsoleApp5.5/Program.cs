﻿using System; 

class Program 
{
    static void Main()
    {
        string[] line = File.ReadAllLines(@"C:\Users\user\Desktop\kirill\ConsoleApp1.5\ConsoleApp5.5\numsTask5.txt"); 
        int[] numbers = Array.ConvertAll(line[0].Split(' '), int.Parse); 

        int maxIndex = 0; 
        int minIndex = 0; 
        
        for (int i = 1; i < numbers.Length; i++) 
        {
            if (numbers[i] < numbers[minIndex]) 
            {
                minIndex = i;
            }
            if (numbers[i] > numbers[maxIndex]) 
            {
                maxIndex = i;
            }
        }
        int start = Math.Min(minIndex, maxIndex) + 1; 
        int end = Math.Max(minIndex, maxIndex);

        double sum = 0; 
        int count = 0; 

        for (int i = start; i < end; i++) 
        {
            sum += numbers[i]; 
            count++; 
        }
        double average = sum / count; 

        Console.WriteLine($"Среднее арифметическое элементов между минимальным и максимальным: {average}"); 
    }
}