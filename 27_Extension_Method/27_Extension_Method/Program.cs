using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefg";
            str = str.ExchangeA();
            Console.WriteLine(str);
        }
    }
}
