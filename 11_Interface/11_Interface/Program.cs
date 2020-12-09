using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("park", "18");
            Buyer buyer = new Customer("kim", "25");    //인터페이스를 자료형으로 사용
            Seller seller = new Customer("lee", "23");

            buyer.buy();
            seller.sell();
            buyer.init();
            customer.order();

        }
    }
}
