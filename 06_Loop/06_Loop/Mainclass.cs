using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Loop
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Ex_For ex_for = new Ex_For();
            ex_for.for_test();
            ex_for.for_each_test();
            ex_for.multi_for_test();

            Ex_While ex_while = new Ex_While();
            ex_while.test_while();
            ex_while.do_while_test();
        }
    }
}
