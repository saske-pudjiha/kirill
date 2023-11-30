using System;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            var temperature = new Dictionary<string, int[]>();

            int minTemp = -30;
            int maxTemp = -9;
            Random random = new Random();
            string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            foreach (string month in months)
            {
                int[] temp = new int [30];
                
                for (int j = 0; j < temp.Length; j++)
                {
                    temp[j] = random.Next(minTemp, maxTemp);
                }
                
                temperature.Add(month, temp);
            }
            var avgTemperature = new Dictionary<string, int>();

            foreach (string month in months)
            {
                int average = 0;
                foreach (var VARIABLE in temperature.GetValueOrDefault(month))
                {
                    
                }
            }
            
            /*
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
            }*/
            
        }
        
        public static void Sort(ref int[] avgTemps)
        {
            Array.Sort(avgTemps);
        }
        
    }
}
        


