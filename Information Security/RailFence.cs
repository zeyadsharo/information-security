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
            string cipher2 = Console.ReadLine();
            Console.Write("Enter your dipth : ");
            int dipth2 = Convert.ToInt32(Console.ReadLine());
            string plain2 = "";
            int length_of_line = cipher2.Length / dipth2;
            int rimainder = (cipher2.Length) - (length_of_line * dipth2);

            for (int i = 0; i < length_of_line; i++)
            {
                for (int j = i; j < cipher2.Length; j += length_of_line)
                {
                    plain2 += cipher2[j];

                    if (rimainder > 0)
                    {
                        j += 1;
                        rimainder--;
                    }
                }
                rimainder = (cipher2.Length) - (length_of_line * dipth2);
            }
            for (int i = 0; i < rimainder; i++)
            {
                plain2 += cipher2[length_of_line + i];
                length_of_line *= 2;
            }
            Console.WriteLine("plant : {0}", plain2);
        }

    }
}
