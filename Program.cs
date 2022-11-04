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
        }
    }
}
 


