using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_Security
{
    class Column
    {

        public Column()
        {
            Console.Write("Enter your plaintext : ");
            string plain = Console.ReadLine();
            Console.Write("Enter your key : "); string key = Console.ReadLine();
            int col = key.Length;
            int row = plain.Length / key.Length;
            int reminder = plain.Length % key.Length;
            if (reminder > 0)
                row = row + 1;
            char[,] m_of_char = new char[row, col];
            int index = 0;
            //put plaintext to matrix
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (index < plain.Length)
                        m_of_char[i, j] = plain[index];
                    else
                        m_of_char[i, j] = 'x';

                    index++;
                }

            }
            //print matrix of char

            for (int i = 0; i < col; i++)
            {
                Console.Write("{0} ", key[i]);

            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("{0} ", m_of_char[i, j]);
                }
                Console.WriteLine();
            }

            int m = 0;
            char[] charx = key.ToCharArray();
            Array.Sort(charx);

            Console.Write("the cipher text is: ");
            while (m < col)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write("{0} ", m_of_char[i, key.IndexOf(charx[m])]);
                }
                m++;
            }

        }
        public void decryption()
        {
            Console.WriteLine("decryption cipher................................");
            Console.Write("Enter your cipher : ");
            string cipher = Console.ReadLine();
            Console.Write("Enter your key : ");
            string key = Console.ReadLine();

            int col = key.Length;
            int row = cipher.Length / key.Length;
            int remin2 = cipher.Length % key.Length;

            if (remin2 > 0)
                row = row + 1;

            char[,] m_of_char2 = new char[row, col];
            int index = 0;


            for (int i = 0; i < col + 1; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (i == key[j] - 48)
                    {
                        for (int ii = 0; ii < row; ii++)
                        {
                            m_of_char2[ii, j] = cipher[index];
                            index++;
                        }
                    }
                }
            }
            //print matrix of char

            for (int i = 0; i < col; i++)
            {
                Console.Write("{0} ", key[i]);

            }
            Console.WriteLine();
            Console.WriteLine("------------------------");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("{0} ", m_of_char2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            string plain2 = "";

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    plain2 += m_of_char2[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("your plain text is : {0} ", plain2);
            Console.ReadLine();





        }
    }
}
