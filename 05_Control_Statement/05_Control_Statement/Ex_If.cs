using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Control_Statement
{
    class Ex_If
    {
        int a = 10;
        public void test_if()
        {
            if (a > 10)
            {
                System.Console.WriteLine("10보다 큰 수");
            }
            else if(a == 10)
            {
                System.Console.WriteLine("10과 같은 수");
            }
            else
            {
                System.Console.WriteLine("10보다 작은 수");
            }
        }
    }
}
