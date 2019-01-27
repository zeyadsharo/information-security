using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_Security
{
    class doublecolumn
    {
        public void encryption()
        {
            Console.Write("Enter your plain textn : ");
            string plain = Console.ReadLine();
            Console.Write("Enter row of matrix : ");
            string key_row = Console.ReadLine();
            Console.Write("Enter colum of matrix : ");
            string key_col = Console.ReadLine();

            char[,] table = new char[key_row.Length, key_col.Length];
            int index = 0;
            for (int i = 0; i < key_row.Length; i++)
            {
                for (int j = 0; j < key_col.Length; j++)
                {
                    if (index < plain.Length)
                        table[i, j] = plain[index];

                    else
                        table[i, j] = 'x';

                    index++;
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("table before encryption ...");
            for (int i = 0; i < key_row.Length; i++)
            {
                for (int j = 0; j < key_col.Length; j++)
                {
                    Console.Write("{0} ", table[i, j]);
                }
                Console.WriteLine();
            }

            string cipher = "";
            for (int i = 0; i < key_row.Length; i++)
            {
                int r = key_row[i] - 49;
                for (int j = 0; j < key_col.Length; j++)
                {
                    int c = key_col[j] - 49;
                    cipher += table[r, c];
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("table after encryption ...");
            char[,] table2 = new char[key_row.Length, key_col.Length];
            int index2 = 0;
            for (int i = 0; i < key_row.Length; i++)
            {

                for (int j = 0; j < key_col.Length; j++)
                {
                    if (index2 < cipher.Length)
                        table2[i, j] = cipher[index2];

                    else
                        table2[i, j] = 'x';

                    index2++;
                }

            }
            for (int i = 0; i < key_row.Length; i++)
            {

                for (int j = 0; j < key_col.Length; j++)
                {
                    Console.Write("{0} ", table2[i, j]);
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("cipher text is : {0}", cipher);
            Console.WriteLine();
        }
    }
}
