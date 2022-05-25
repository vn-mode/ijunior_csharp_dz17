using System;

namespace vn_mode_csharp_dz17
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            int degree = 1;
            int result;
            int ourNumber = 2;
            int minimumRandomNumber = 1;
            int maximumRandomNumber = 100;

            result = ourNumber;
            Random random = new Random();
            randomNumber = random.Next(minimumRandomNumber, maximumRandomNumber);

            for (int i = 1; result < randomNumber; i = i * ourNumber)
            {
                result *= ourNumber;
                degree++;
            }

            if (randomNumber == result)
            {
                result *= ourNumber;
                degree++;
            }

            Console.WriteLine($"Исходное число: {randomNumber}\n{ourNumber} в степени: {degree}\nРезультат возведения в степень: {result}");

        }
    }
}
