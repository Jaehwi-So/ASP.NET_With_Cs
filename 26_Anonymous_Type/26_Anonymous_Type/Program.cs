using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Anonymous_Type
{
    class Program
    {
        /* 익명 타입(Anonymous Type)
         * 일반적으로 C#에서 클래스를 사용하기 위해서는 먼저 클래스를 정의한 후 사용한다.
         * 그렇지만 C# 3.0부터 클래스를 미리 정의하지 않고 사용 가능하게 만드는 익명타입을 지원한다.
         */
        static void Main(string[] args)
        {
            //익명 타입의 객체에 변수를 할당할 때에는 특별한 타입명이 없으므로 var를 사용한다. 컴파일러는 익명 타입에 대해 내부적으로 임의의 클래스를 생성하여 사용하게 된다.
            var v = new[]   
            {
               new {Name="kim", Age=20, Gender="Male"},
               new {Name="park", Age=25, Gender="Female"},
               new {Name="lee", Age=38, Gender="Male"},
               new {Name="jung", Age=50, Gender="Female"}
            };


            //익명 타입은 LINQ(Link to SQL)을 사용할 때 많이 사용된다.
            //Select()메소드를 사용하여 일부 컬럼들로만 구성된 새 익명 타입을 만들어 리턴한다.
            var list = v.Where(p => p.Age >= 30).Select(p => new { p.Name, p.Age });
            foreach(var a in list)
            {
                Console.WriteLine(a.Name + " " + a.Age);
            }
        }
    }
}
