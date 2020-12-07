using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Loop
{
    class Ex_While
    {
        /* while */
        public void test_while()
        {
            int i = 1;
            int sum = 0;
            int key;
            while (i <= 10)
            {
                Console.Write("정수를 입력하세요 : ");
                key = Int32.Parse(Console.ReadLine());
                sum += key;
                i++;
            }
            Console.WriteLine(sum);
        }

        /* do while */
        public void do_while_test()
        {
            int i = 1;
            do
            {
                Console.Write(i + " ");
                i++;
            } while (i < 10);
            Console.WriteLine();
        }
    }
}
