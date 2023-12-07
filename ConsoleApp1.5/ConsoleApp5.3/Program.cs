using System;

class Program
{
    static void Main()
    {
        string pathInput = (@"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.5\ConsoleApp5.3\numsTask3.txt");
        int[] nums;
        StreamReader readTask2 = new StreamReader(pathInput);
        string[] input = readTask2.ReadLine().Split(" ");
        nums = new int[input.Length];
        
        readTask2.Close();
        
        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
        }
        int minIndex = 0;
        int maxIndex = 0;
            
        for (int i = 0; i < nums.Length; i++)
        {
            
            if (nums[maxIndex] < nums[i])
            {
                maxIndex = i;
            }

            if (nums[minIndex] > nums[i])
            {
                minIndex = i;
            }
        }
        int minIndexN;
        int maxIndexN;

        if (minIndex < maxIndex)
        {
            minIndexN = minIndex;
            maxIndexN = maxIndex;
        }
        else
        {
            minIndexN = maxIndex;
            maxIndexN = minIndex;
        }

        int sum = 0;

        int count = 0;
        
        
        for (int i = minIndexN + 1; i < maxIndexN; i++)
        {
            sum += nums[i];
            count++;
        }
        Console.WriteLine(sum / count);
    }
}