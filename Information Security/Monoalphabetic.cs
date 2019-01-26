using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_Security
{
    class Monoalphabetic
    {
        
        string key2 = "";

        public Monoalphabetic ()
        {
            Console.WriteLine("----------Welcome to Monoalphabetic cipher---------");
        }
        public void incyption()
        {
            //incyption
            Console.Write("Enter your plaintext: ");
            string plain = Console.ReadLine();
            Console.Write("Enter your key: ");
            string key = Console.ReadLine();
            int c = 0;
             key2 = key;
            for (int i = 0; i < plain.Length;i++)
            {
                if (key2.Length != plain.Length)
                {
                    key2 += key[c++];
                    if (c == key.Length)
                        c = 0;
                }
            }
            Console.WriteLine("Your key : {0}\n", key2);
            string cipher = "";

            for (int i = 0; i < plain.Length; i++)
            {
                //if (plain[i] == ' ')
                //    cipher += ' ';
                //else
                    cipher += key2[plain[i] - 97];
            }
            Console.WriteLine("your cipher is : {0}", cipher);
        }
        public void decryption()
            {
                //decryption 
                Console.Write("Enter your ciphertext : ");
                string cipher2 = Console.ReadLine();
                string plain2 = "";
                for (int i = 0; i < cipher2.Length; i++)
                {
                    plain2 += (char)(key2.IndexOf(cipher2[i]) + 97);
                }
                Console.WriteLine("your cipher is : {0}", plain2);
                Console.ReadLine();
            }
        }   

    }
