using System;

namespace Program;

class Program
{
    static void Main()
    {
        string[] path = File.ReadAllLines(@"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.5\ConsoleApp5.4\numsTask4");
        string[] line = path[0].Split(" ");
        int[] nums = new int[line.Length];

        for (int i = 0; i < line.Length; i++)
        {
            nums[i] = Int32.Parse(line[i]);
        }

        int maxValue;
        int indexMax;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums[i])
            {
                maxValue = nums[i];
                indexMax = i;
            }
        }
    }
}

