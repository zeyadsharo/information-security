using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_Security
{
    class Vigenere
    {
        char[] ciphertext;
        char[] plan;
        string key = "CAFE";
      string  plantext = "TELL";
        public void print_table()
        {
            for (int i = 0; i < 26; i++)
            {
                for (int j = i; j < 26 + i; j++)
                {
                    Console.Write((char)(j % 26 +97) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void incyption()
        {
            for (int i = 0; i < plantext.Length; i++)
            {
                for (int T = 0; T < key.Length; T++)
                {
                    if (key.Length != plantext.Length)
                    {
                        key = key + key[T];
                    }
                }
            }
          
            ciphertext = new char[plantext.Length];
            for (int i = 0; i < plantext.Length; i++)
            {
                ciphertext[i] = Convert.ToChar(((plantext[i] + key[i]) % 26) + 65);
            }
            Console.Write("ciphertext: ");
            for (int i = 0; i < ciphertext.Length; i++)
            {
                Console.Write(ciphertext[i]);
            }
        }
        public void decryption()
        {
          
            Console.Write("\nEnter the cipher text: ");
            string ciphertext = Console.ReadLine();
            plan = new char[ciphertext.Length];
            for (int i = 0; i < ciphertext.Length; i++)
            {
                plan[i] = Convert.ToChar((((ciphertext[i] - key[i]) + 26) % 26)+65);
            }
            Console.WriteLine();
            Console.Write("plan text: ");
            for (int i = 0; i < plan.Length; i++)
            {
                Console.Write(plan[i]);
            }
        }
    }
}
