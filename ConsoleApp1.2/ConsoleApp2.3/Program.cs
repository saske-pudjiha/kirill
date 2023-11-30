using System;

class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());

        int[,] matrix = new int[numbers, numbers];

        for (int i = 0; i < numbers; i++)
        {
            matrix[i, 0] = 1;
            matrix[0, i] = 1;
        }
        for (int i = 1; i < numbers; i++)
        {
            for (int j = 1; j < numbers; j++)
            {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }

        for (int i = 0; i < numbers; i++)
        {
            for (int j = 0; j < numbers; j++)
            {
                Console.Write($"{matrix[i,j],+6}");
            }
            Console.WriteLine();
        }
    }
}