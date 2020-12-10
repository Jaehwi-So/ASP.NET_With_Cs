using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Partial
{
    public partial class ExamPartialClass : ExamPartialInterface
    {
        public void Hello()
        {
            Console.WriteLine(this.Name + " hello");
        }

        public void Bye()
        {
            Console.WriteLine(this.Name + " bye");
        }

        partial void PartialBodyMethod()
        {
            Console.WriteLine("partial method");
        }
    }
}
