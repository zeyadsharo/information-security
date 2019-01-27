using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_Security
{
    class test
    {
        public test()
        {

            Console.Write("enter the plaintext: ");
            string plaintext = Console.ReadLine();
            Console.Write("enter the key with column: ");
            string key = Console.ReadLine();
            int col = key.Length;
            int row = plaintext.Length / key.Length;
            int reminder = plaintext.Length % key.Length;
            char[,] p_to_char = new char[row, col];
            if (reminder > 0)
                row += 1;
            int index = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (index < plaintext.Length)
                        p_to_char[i, j] = plaintext[index];
                    else
                        p_to_char[i, j] = 'x';
                    index++;
                }
            }
            for (int i = 0; i < key.Length; i++)
            {
                Console.Write(key[i]);
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(p_to_char[i,j]);
                }
                Console.WriteLine();
            }

                    Console.WriteLine();
        }
    }
}
