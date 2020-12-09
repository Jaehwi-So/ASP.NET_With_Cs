using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface
{
    //Member를 상속받으면서 Buyer, Seller의 인터페이스를 구현
    //다중 상속은 불가능하나 여러개의 인터페이스를 구현하는 것은 가능하다.
    public class Customer : Member, Buyer, Seller
    {
        public Customer(string name, string age) : base(name, age)  //base == JAVA에서의 super()
        {

        }

        public void init()
        {
            Console.WriteLine("초기화 " + this.Name);
        }

        public void order()
        {
            Console.WriteLine("주문 " + this.Name);
        }

        public void quit()
        {
            Console.WriteLine("판매 종료 " + this.Name);
        }

        public void sell()
        {
            Console.WriteLine("판매 " + this.Name);
        }
        public void buy()
        {
            Console.WriteLine("구매 " + this.Name);
        }
    }
}
