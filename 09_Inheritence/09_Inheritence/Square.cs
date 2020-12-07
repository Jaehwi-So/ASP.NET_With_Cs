using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Inheritence
{
    public class Square : Rectangle
    {
        public Square(double w) : base(w, w)
        {

        }

        //부모 클래스의 메서드를 오버라이딩한다.
        public override string showInfo()
        {
            return "한 변의 길이 : " + this.height + " 넓이 : " + this.calcArea();
        }
    }
}
