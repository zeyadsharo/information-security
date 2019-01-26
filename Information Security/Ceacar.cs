using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_Security
{
   
    class Ceacar
    {
        public Ceacar()
        {
            Console.WriteLine("----------Welcome to Ceacar cipher---------");
        }
        public void printchareter()
        {
            Console.Write("charecter : ");
            char[] charecter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'x' };
            for (int i = 0; i < charecter.Length; i++)
            {
                if (i > 10)
                    Console.Write("  " + charecter[i]);
                else
                    Console.Write(" " + charecter[i]);
            }
            Console.WriteLine();
            Console.Write("index     : ");
            for (int i = 0; i < charecter.Length; i++)
            {
                Console.Write(" " + i);
            }
        }
        public void ConvertP_C()
        {
            Console.WriteLine("\n ");
            Console.WriteLine("Convert plantext to Ciphertext....");
            Console.Write("Enter your Plantext : ");
            string plan = Console.ReadLine();
            string cipher = "";
            Console.Write("Enter key : ");
            int key = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < plan.Length; i++)
            {
                cipher += (char)((plan[i] - 97 + key) % 26 + 97);
            }
            Console.WriteLine("Ciphertext is : " + cipher);
            Console.WriteLine();
        }
        public void ConvertC_P()
        {
            // convert cophertext to plantext

            Console.WriteLine("Convert ciphertext to plantext....");

            Console.WriteLine();
            Console.Write("Enter your ciphertext : ");
            string cipher2 = Console.ReadLine();
            Console.Write("Enter key : ");
            int key = Convert.ToInt32(Console.ReadLine());
            string plan2 = "";
            for (int i = 0; i < cipher2.Length; i++)
            {
                plan2 += (char)((cipher2[i] - 97 - key + 26) % 26 + 97);
            }
            Console.WriteLine("plantext is : " + plan2);
        }
    }
}
