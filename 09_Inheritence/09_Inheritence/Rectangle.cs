using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Inheritence
{
    public class Rectangle
    {
        protected double width; 
        protected double height;
        public Rectangle(double w, double l)
        {
            this.width = w;
            this.height = l;
        }
        public double Width
        {
            get { return width; }
            set { this.height = value; }
        }
        public double Height
        {
            get { return height; }
            set { this.height = value; }
        }
        public double calcArea()
        {
            return this.width * this.height;
        }

        //자식 클래스에서 메서드 오버라이딩을 하기 위해서는 abstract나 virtual 한정자가 필요하다.
        //abstract는 구현체가 없고 virtual은 구현체가 있다는 것이 특징
        public virtual string showInfo()
        {
            return "가로 : " + width + " 세로 : " + height + " 넓이 : " + calcArea();
        }
    }
}
