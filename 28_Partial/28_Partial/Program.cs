using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Partial
{
    //Partial 타입은 Code Generator가 만든 코드와 사용자가 만드는 코드를 분리하기 위함이다. 즉 개발자에게 포커스 해야하는 코드를 분리해 준다는 점에서 도움이 된다.

    //예를 들어 ASP.NET 웹 폼에서 하나의 웹 페이지를 만들 때 page.aspx.designer.cs, page1.aspx, page1.aspx.cs와 같은 3개의 파일을 만드는데 
    //page1.aspx 이외의 .cs 파일 안에는 partial 클래스를 사용하여 분리해두었다.
    //웹 개발자는 Code Behind라고 불리는 page1.aspx.cs 파일에서 주로 작업한다.
    class Program
    {
        //Partial struct
        partial struct ExamStruct
        {
            public string name;
            public int age;
        }

        partial struct ExamStruct
        {
            public void getInfo()
            {
                Console.WriteLine(name + " " + age);
            }
        }
        static void Main(string[] args)
        {
            //Partial Class와 Partial Interface의 사용(ExamPartialClass.cs와 ExamPartialClass2.cs에 코드가 분리되어 있다) 
            ExamPartialInterface partialClass = new ExamPartialClass("kim", 23);
            partialClass.Name = "sjh";
            partialClass.Hello();
            partialClass.Bye();
            partialClass.PartialMethod();

            //Partial Struct의 사용
            ExamStruct exam = new ExamStruct();
            exam.name = "kim";
            exam.age = 15;
            exam.getInfo();
        }
    }
}
