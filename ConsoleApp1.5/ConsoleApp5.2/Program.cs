using System;

class Program
{
    static void Main()
    {
        string pathInput = (@"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.5\ConsoleApp5.2\numsTask2.txt");
        float[] nums;
        StreamReader readTask2 = new StreamReader(pathInput);
        string[] input = readTask2.ReadLine().Split(";");
        nums = new float[input.Length];
        
        readTask2.Close();

        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = float.Parse(input[i]);
        }

        Array.Sort(nums);    
        
        File.WriteAllText(@"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.5\ConsoleApp5.2\numsTask2.txt", string.Join(";", nums));
        

    }
}