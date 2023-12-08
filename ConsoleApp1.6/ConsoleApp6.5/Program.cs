using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк:");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов:");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        // Ввод матрицы
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите элементы {i + 1}-й строки, разделенные пробелом: ");
            string[] input = Console.ReadLine().Split(' ');
            
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }
        // Создание новой матрицы
        int[,] newMatrix = new int[n, m + 1];
        for (int i = 0; i < n; i++)
        {
            int count = 0;

            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = matrix[i, j];
                count += matrix[i, j];
            }

            newMatrix[i, m] = count % 2;
        }
        // Вывод новой матрицы
        Console.WriteLine("Новая матрица:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}