using System;

namespace vn_mode_csharp_dz17
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            int degree = 1;
            int dynamicNumber;
            int sourceNumber = 2;

            dynamicNumber = sourceNumber;
            Random rand = new Random();
            randomNumber = rand.Next(1, 100);

            for (int i = 1; dynamicNumber < randomNumber; i = i * sourceNumber)
            {
                dynamicNumber *= sourceNumber;
                degree++;
            }

            if (randomNumber == dynamicNumber)
            {
                dynamicNumber *= sourceNumber;
                degree++;
            }
            
            Console.WriteLine($"Исходное число: {randomNumber}\n{sourceNumber} в степени: {degree}\nРезультат возведения в степень: {dynamicNumber}");

        }
    }
}
