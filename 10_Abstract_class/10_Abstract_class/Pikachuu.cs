using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Abstract_class
{
    public class Pikachuu : Pokemon
    {
        public Pikachuu() : base("피카츄")
        {

        }
        public override string attack()
        {
            return "백만볼트";
        }
    }
}
