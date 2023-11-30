using System;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            int[,] temperature = new int[12, 30];
            int minTemp = -32;
            int maxTemp = -10;
            Random random = new Random();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temperature[i, j] = random.Next(minTemp, maxTemp);
                }

                if (i < 6)
                {
                    minTemp += 6;
                    maxTemp += 7;
                }

                if (i > 6)
                {
                    minTemp -= 12;
                    maxTemp -= 11;
                }
            }

            static int[] avgTemp(int[,] temperature)
            {
                int[] avgTemps = new int[12];
                int sum = 0;

                for (int i = 0; i < 12; i++)
                {
                    sum = 0;
                    for (int j = 0; j < 30; j++)
                    {
                        sum += temperature[i, j];
                    }

                    avgTemps[i] = sum / 30;
                }

                return avgTemps;
            }

            int[] avgTemps = avgTemp(temperature);
            
            Sort(ref avgTemps);
            
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(avgTemps[i] + " ");
            }
        }
        
        public static void Sort(ref int[] avgTemps)
        {
            Array.Sort(avgTemps);
        }
        
    }
}
