using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFInfoBez
{
    internal class CharacterProcessing
    {
        static string Encrypt(string text)
        {
            string result = "";
            string alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            string key = "впрзутоыщшхьэъсйяфжэюкмчлнигбдва";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    int index = alphabet.IndexOf(char.ToLower(text[i]));
                    if (char.IsUpper(text[i]))
                    {
                        result += char.ToUpper(key[index]);
                    }
                    else
                    {
                        result += key[index];
                    }
                }
                else
                {
                    result += text[i];
                }
            }
            return result;
        }

        static string Decrypt(string text)
        {
            string result = "";
            string alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            string key = "впрзутоыщшхьэъсйяфжэюкмчлнигбдва";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    int index = key.IndexOf(char.ToLower(text[i]));
                    if (char.IsUpper(text[i]))
                    {
                        result += char.ToUpper(alphabet[index]);
                    }
                    else
                    {
                        result += alphabet[index];
                    }
                }
                else
                {
                    result += text[i];
                }
            }
            return result;
        }

        /*static void Main()
        {
            Console.WriteLine("Введите текст для шифрования:");
            string plaintext = Console.ReadLine();

            string encryptedText = Encrypt(plaintext);
            Console.WriteLine("Зашифрованный текст: " + encryptedText);

            string decryptedText = Decrypt(encryptedText);
            Console.WriteLine("Расшифрованный текст: " + decryptedText);
        }*/
    }
}
