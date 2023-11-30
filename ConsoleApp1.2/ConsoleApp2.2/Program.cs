using System;

namespace App1
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 1 + i * 4;
                Console.WriteLine(arr[i]);
            }
           
        }
    }
}