using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Class
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            ExamClass exam = new ExamClass(20, "sjh");
            Console.WriteLine(exam.Name + " " + exam.Age);  //getter 메서드가 호출되어 필드값 얻어내기.
            exam.Age = 22;  //setter 메서드가 호출되어 필드값 변경
            exam.getInfo();

            
        }
    }
}
