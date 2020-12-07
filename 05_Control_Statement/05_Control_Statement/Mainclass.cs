using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Control_Statement
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Ex_If ex_if = new Ex_If();
            Ex_Switch_case ex_switch = new Ex_Switch_case();

            ex_if.test_if();
            ex_switch.switch_test();
        }
    }
}
