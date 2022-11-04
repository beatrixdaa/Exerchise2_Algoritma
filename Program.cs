using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerchise2_Algoritma
{
    internal class Program
    {
        int[] beatrix = new int[21];

        //Number of elements in array
        int n, i, ba, val, flag;
        void input()
        {

            while (true)
            {
                Console.Write("Masukkan jumlah element array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 21)
                    break;
                else
                    Console.WriteLine("\nArray dapat memiliki maksimum 21 element \n");

            }
            Console.WriteLine("\n==============");
            Console.WriteLine("Masukkan Elements Array");
            Console.WriteLine("\n================");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                beatrix[i] = Int32.Parse(s1);
            }

         }
     }
  }
