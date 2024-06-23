    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFInfoBez
{
    internal class SundaramSieve
    {
        static void Sundaram()
        {
            Console.WriteLine("Введите значение N:");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= (Math.Sqrt(2 * N + 1) - 1) / 2; i++)
            {
                for (int j = i; j <= (N - i) / (2 * i + 1); j++)
                {
                    int num = i + j + 2 * i * j;
                    if (num <= N)
                    {
                        Console.WriteLine($"Исключаем число: {num}");
                    }
                    else
                    {
                        int result = 2 * num + 1;
                        Console.WriteLine($"Обрабатываем оставшееся число: {result}");
                    }
                }
            }
        }
    }
}