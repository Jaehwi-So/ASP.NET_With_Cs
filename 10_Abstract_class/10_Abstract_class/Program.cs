using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Pikachuu pikachuu = new Pikachuu();
            Ggobbugi ggobbugi = new Ggobbugi();
            Console.WriteLine(pikachuu.getName() + " " + pikachuu.attack());
            Console.WriteLine(ggobbugi.getName() + " " + ggobbugi.attack());
        }
    }
}
