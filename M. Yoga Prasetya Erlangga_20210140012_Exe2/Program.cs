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
        public void sort2()
        {
            char ch;
            do
            {
                // accept the number to be searched
                Console.Write
                    ("\n Enter element want you to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                // apply benary search
                int lowerbound = 0;
                int upperbound = n - 1;

                // obtain the index of the middle elements
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                // loop to search for the elemenets int the array
                while ((item != yoga[mid]) && (lowerbound <= upperbound))
                {
                    if (item > yoga[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == yoga[mid])
                    Console.WriteLine("\n" + item.ToString() + "Found at position"
                        + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "Not found int the array \n");
                Console.WriteLine("\n Number of comparasion : " + ctr);

                Console.WriteLine("\n Continue search (y/n)");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
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
            Program exe = new Program();
            int menu;
            Console.WriteLine("Menu Option");
            Console.WriteLine("===========");
            Console.WriteLine("1. Sort1");
            Console.WriteLine("2. Sort2");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choise (1,2,3) : ");
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("..............");
                    Console.WriteLine(" Sort1 Search");
                    Console.WriteLine("..............");
                    exe.input();
                    exe.sort1();
                    exe.display();
                    Console.WriteLine("Prees enter to exit. ");
                    Console.Read();
                    break;
                    case 2:
                    Console.WriteLine("");
                    Console.WriteLine("..............");
                    Console.WriteLine(" Sort2 Search");
                    Console.WriteLine("..............");
                    exe.input();
                    exe.sort2();
                    break;
            }
        }
    }
}
