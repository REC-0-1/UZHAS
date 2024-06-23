using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFInfoBez
{
    internal class AffinCaesar
    {
        static string Encrypt(string text, int a, int b)
        {
            string result = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'А' : 'а';

                    char encryptedChar = (char)((((a * (char.ToUpper(c) - baseChar) + b) % 32) + baseChar)); 
                    result += encryptedChar;
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        static string Decrypt(string text, int a, int b)
        {
            string result = "";
            int aInverse = 0;
            for (int i = 0; i < 32; i++) 
            {
                if ((a * i) % 32 == 1)
                {
                    aInverse = i;
                    break;
                }
            }

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'А' : 'а'; 

                    char decryptedChar = (char)(((aInverse * (char.ToUpper(c) - baseChar - b + 32) % 32) + baseChar));
                    result += decryptedChar;
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        /*static void Main()
        {
            Console.WriteLine("Enter the text to encrypt:");
            string plaintext = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter value for a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for b:");
            int b = int.Parse(Console.ReadLine());

            string encryptedText = Encrypt(plaintext, a, b);
            Console.WriteLine("Encrypted Text: " + encryptedText);

            string decryptedText = Decrypt(encryptedText, a, b);
            Console.WriteLine("Decrypted Text: " + decryptedText);
        }*/
    }
}

