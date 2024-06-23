using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFInfoBez
{
    internal class CyclicGenerationSsessionKeyTwo
    {
        static ushort GetNextCounterValue(ushort counter)
        {
            return (ushort)(counter + 1);
        }

        static ushort GenerateSessionKey(ushort counter, ushort masterKey)
        {
            ushort masterKeyPrime = masterKey;

            ushort sessionKey = Encrypt(masterKeyPrime, GetNextCounterValue(counter));

            return sessionKey;
        }

        static ushort Encrypt(ushort masterKey, ushort value)
        {
            ushort encryptedValue = (ushort)((masterKey + value) % ushort.MaxValue);
            return encryptedValue;
        }

        /*static void Main()
        {
            Console.WriteLine("Введите начальное значение счетчика (от 0 до 65535):");
            ushort initialCounterValue;
            while (!ushort.TryParse(Console.ReadLine(), out initialCounterValue) || initialCounterValue > 65535)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите значение от 0 до 65535.");
            }

            Console.WriteLine("Введите мастер-ключ (от 0 до 65535):");
            ushort masterKey;
            while (!ushort.TryParse(Console.ReadLine(), out masterKey) || masterKey > 65535)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите значение от 0 до 65535.");
            }

            ushort sessionKey = GenerateSessionKey(initialCounterValue, masterKey);
            Console.WriteLine("Сеансовый ключ: " + sessionKey);
        }*/
    }
}
