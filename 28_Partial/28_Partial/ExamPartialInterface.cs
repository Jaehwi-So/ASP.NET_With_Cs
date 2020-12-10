using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Partial
{
    public partial interface ExamPartialInterface
    {
        string Name { set; get; }
        int Age { set; get; }
        void Hello();
    }
}
