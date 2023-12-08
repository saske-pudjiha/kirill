using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int length = random.Next(1, 10);
        double[] array = GenerateRandomArray(length, random);
        
        List<double> positiveElements = new List<double>();
        List<double> negativeElements = new List<double>();
        
        foreach (double number in array)
        {
            if (number > 0)
            {
                positiveElements.Add(number);
            }
            else if (number < 0)
            {
                negativeElements.Add(number);
            }
        }
        
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Console.WriteLine("\nПоложительные элементы:");
        PrintArray(positiveElements);

        Console.WriteLine("\nОтрицательные элементы:");
        PrintArray(negativeElements);

        Console.ReadLine();
    }

    static double[] GenerateRandomArray(int length, Random random)
    {
        double[] array = new double[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = random.NextDouble() * (random.Next(0, 2) == 0 ? -1 : 1);
        }
        return array;
    }

    static void PrintArray(IEnumerable<double> array)
    {
        foreach (double number in array)
        {
            Console.Write(number + " ");
        }
    }
}