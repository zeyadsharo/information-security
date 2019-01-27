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
            Console.WriteLine("decryption cipher................................");
            Console.Write("Enter your cipher : ");
            string cipher2 = Console.ReadLine();
            Console.Write("Enter your key : ");
            string key2 = Console.ReadLine();

            int col2 = key2.Length;
            int row2 = cipher2.Length / key2.Length;
            int remin2 = cipher2.Length % key2.Length;

            if (remin2 > 0)
                row2 = row2 + 1;

            char[,] m_of_char2 = new char[row2, col2];
            int index2 = 0;


            for (int i = 0; i < col2 + 1; i++)
            {
                for (int j = 0; j < key2.Length; j++)
                {
                    if (i == key2[j] - 48)
                    {
                        for (int ii = 0; ii < row2; ii++)
                        {
                            m_of_char2[ii, j] = cipher2[index2];
                            index2++;
                        }
                    }
                }
            }



            //print matrix of char

            //for (int i = 0; i < col; i++)
            //{
            //    Console.Write("{0} ", key[i]);

            //}
            Console.WriteLine();
            Console.WriteLine("------------------------");
            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {


                    Console.Write("{0} ", m_of_char2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            string plain2 = "";

            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
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
