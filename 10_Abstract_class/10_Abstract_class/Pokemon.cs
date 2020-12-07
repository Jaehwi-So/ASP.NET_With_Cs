using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Abstract_class
{
    public abstract class Pokemon
    {
        private string name;
        public Pokemon(string name) { this.name = name; }
        public string getName()
        {
            return this.name;
        }

        //구현된 메서드
        public string getInfo()
        {
            return this.name;
        }

        //구현되지 않은 추상 메서드. 자식 클래스에서 오버라이딩하여 사용
        public abstract string attack();

    }
}
