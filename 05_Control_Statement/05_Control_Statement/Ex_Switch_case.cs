using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Control_Statement
{
    class Ex_Switch_case
    {
        string fruit = "apple";
        public void switch_test()
        {
            switch (fruit)
            {
                case "apple":
                    System.Console.WriteLine("사과 입니다");
                    break;
                case "grape":
                    System.Console.WriteLine("포도 입니다");
                    break;
                case "pear":
                    System.Console.WriteLine("배 입니다");
                    break;
                default:
                    System.Console.WriteLine("알 수 없는 과일입니다.");
                    break;
            }
        }
    }
}
