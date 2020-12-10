using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Partial
{
    public partial class ExamPartialClass : ExamPartialInterface
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ExamPartialClass(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //Partial Method의 사용 : 메서드를 분리하여 사용.
        public void PartialMethod()
        {
            PartialBodyMethod();
        }

        partial void PartialBodyMethod();


    }
}
