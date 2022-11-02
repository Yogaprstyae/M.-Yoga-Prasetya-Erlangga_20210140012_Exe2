using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Yoga_Prasetya_Erlangga_20210140012_Exe2
{
    class Program
    {
        int[] yoga = new int[52];
        int n;
        int i;

        public void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of elements in yeh array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 52))
                    break;
                else
                    Console.WriteLine("Array maksimum 52 number of data");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Enter Array Elements ");
            Console.WriteLine("----------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                yoga[i] = Int32.Parse(s1);
            }
        }
        public void sort1()
        {
            for (int i = 0; i < n; i++)
            {
                int temp = yoga[i];
                int MY = i - 1;
                while (MY >= 0 && yoga[MY] > temp)
                {
                    yoga[MY + 1] = yoga[MY];
                    MY--;
                }
                yoga[MY + 1] = temp;
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" Shorted Array Elements ");
            Console.WriteLine("------------------------");
            for (int MY = 0; MY < n; MY++)
            {
                Console.WriteLine(yoga[MY]);
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
        }
    }
}
