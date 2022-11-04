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

        public void insertionsort()
        {
            for (i = 1; i < n; i++)
            {
                val = beatrix[i];
                flag = 0;
                for (ba = i - 1; ba >= 0 && flag != 1;)
                {
                    if (val < beatrix[ba])
                    {
                        beatrix[ba + 1] = beatrix[ba];
                        ba--;
                        beatrix[ba + 1] = val;

                    }
                    else flag = 1;
                }

            }
        }
        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = (left);
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {

                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }
        void display()
        {
            Console.WriteLine("/n------------------");
            Console.WriteLine("Elemen array yang diurutkan");
            Console.WriteLine("--------------------------");
        }

    }
}