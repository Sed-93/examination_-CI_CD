using System;

namespace EncryptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in användarens text
            Console.Write("Ange text att kryptera: ");
            string inputText = Console.ReadLine();

            // Läs in förskjutningen
            Console.Write("Ange förskjutning: ");
            int shift = int.Parse(Console.ReadLine());

            // Kryptera och skriv ut
            string ciphertext = Encrypt(inputText, shift);
            Console.WriteLine($"Krypterad text: {ciphertext}");

            // Dekryptera och skriv ut
            string decryptedText = Decrypt(ciphertext, shift);
            Console.WriteLine($"Dekrypterad text: {decryptedText}");
        }

        public static string Encrypt(string plaintext, int shift)
        {
            char[] buffer = plaintext.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shift);
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        public static string Decrypt(string ciphertext, int shift)
        {
            char[] buffer = ciphertext.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter - shift);
                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}
