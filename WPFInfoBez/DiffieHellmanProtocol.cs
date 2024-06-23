using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WPFInfoBez
{
    internal class DiffieHellmanProtocol
    {
        /*static void Main()
        {
            // Генерация простого числа p и генератора g
            BigInteger p = GeneratePrimeNumber();
            BigInteger g = GenerateGenerator(p);

            // Генерация секретных ключей x и y
            BigInteger x = GenerateSecretKey(p);
            BigInteger y = GenerateSecretKey(p);

            // Вычисление открытых ключей Ka и Kb
            BigInteger Ka = BigInteger.ModPow(g, x, p);
            BigInteger Kb = BigInteger.ModPow(g, y, p);

            // Вычисление общего секретного ключа
            BigInteger K = BigInteger.ModPow(Kb, x, p);

            Console.WriteLine($"Открытый ключ пользователя A (Ka): {Ka}");
            Console.WriteLine($"Открытый ключ пользователя B (Kb): {Kb}");
            Console.WriteLine($"Общий секретный ключ (K): {K}");
        }
        */
        static BigInteger GeneratePrimeNumber()
        {
            Random random = new Random();
            int[] primes = { 2, 3, 5, 7 };
            return new BigInteger(primes[random.Next(0, 4)]);
        }

        static bool IsPrime(BigInteger number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number <= 3)
            {
                return true;
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }
            int k = 5;
            while (BigInteger.Pow(k, 2) <= number)
            {
                if (number % k == 0 || number % (k + 2) == 0)
                {
                    return false;
                }
                k += 6;
            }
            return true;
        }

        static BigInteger GenerateGenerator(BigInteger p)
        {
            Random random = new Random();
            return random.Next(1, 11);

            static BigInteger GenerateSecretKey(BigInteger p)
            {
                Random random = new Random();
                return BigInteger.Remainder(new BigInteger(random.Next()), p - 2) + 1;
            }

        }
    }
}
