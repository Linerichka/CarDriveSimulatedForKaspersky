using System;

namespace Tests
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            long count = 0;
            Random random = new Random();
            long resultS = 0;
            long resultF = 0;
            
            while (true)
            {
                for (int i = 0; i < 100000; i++)
                {
                    RideCar(ref resultS, ref resultF, random);
                    count++;
                }

                Console.WriteLine($"count: {count}, result: {(double)resultS / (double)resultF}");
            }
        }

        public static void RideCar(ref long resultS, ref long resultF, Random random)
        {
            // Если погода благоприятная
            if (0.8f >= random.NextDouble())
            {
                if (0.9f >= random.NextDouble())
                {
                    resultS++;
                }
                else
                {
                    resultF++;
                }
            }
            // Погода неблагоприятная
            else
            {
                // Автомат сработал
                if (0.7f >= random.NextDouble())
                {
                    if (0.9f >= random.NextDouble())
                    {
                        resultS++;
                    }
                    else
                    {
                        resultF++;
                    }
                }
                // Управление на водителе
                else
                {
                    if (0.5f >= random.NextDouble())
                    {
                        resultS++;
                    }
                    else
                    {
                        resultF++;
                    }
                }
            }
        }
    }
}