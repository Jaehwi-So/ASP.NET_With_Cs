using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Abstract_class
{
    public class Ggobbugi : Pokemon
    {
        public Ggobbugi() : base("꼬부기")
        {
        }

        //추상 메서드 오버라이딩
        public override string attack()
        {
            return "물대포";
        }
    }
}
