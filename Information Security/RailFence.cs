using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_Security
{
    class RailFence
    {
        public void incyption()
        {
            Console.Write("Enter Your Plain text : ");
            string plaintext = Console.ReadLine();
            Console.Write("Enter number of line : ");
            int line = Convert.ToInt32(Console.ReadLine());
            string[] ciphertext = new string[plaintext.Length];
            int count = 0;
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < plaintext.Length; j++)
                {
                    if (j % line == i)
                    {
                        ciphertext[count++] = plaintext[j].ToString();
                        Console.Write(plaintext[j] + "    ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("Cipher text : ");
            for (int i = 0; i < ciphertext.Length; i++)
                 Console.Write(ciphertext[i]);
            Console.WriteLine("\n\n");
        }
        public void decryption()
        {

            Console.Write("Enter your ciphertext : ");
            string cipher = Console.ReadLine();
            Console.Write("Enter your line : ");
            int line = Convert.ToInt32(Console.ReadLine());
            string plaintext = "";
            int length_of_line = cipher.Length / line;
            int rimainder = (cipher.Length) - (length_of_line * line);

            for (int i = 0; i < length_of_line; i++)
            {
                for (int j = i; j < cipher.Length; j += length_of_line)
                {
                    plaintext += cipher[j];
                    if (rimainder > 0)
                    {
                        j += 1;
                        rimainder--;
                    }
                }
                rimainder = (cipher.Length) - (length_of_line * line);
            }
            for (int i = 0; i < rimainder; i++)
            {
                plaintext += cipher[length_of_line + i];
               // length_of_line *= 2;
            }
            Console.WriteLine("plant : {0}", plaintext);
        }

    }
}
