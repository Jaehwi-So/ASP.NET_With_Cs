using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Loop
{
    class Ex_For
    {
        /* for */
        public void for_test()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        /* multi_for */
        public void multi_for_test()
        {
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    Console.Write(i + "x" + j + "=" + i * j + "  ");
                }
                Console.WriteLine();
            }
        }

        /* foreach */
        public void for_each_test()
        {
            string[] array = { "apple", "grape", "banana", "pear" };
            foreach(string s in array)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
       
    }
}
