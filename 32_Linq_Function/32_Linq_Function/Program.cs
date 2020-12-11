using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Linq_Function
{
    class Program
    {
        /* Linq 문법은 데이터베이스의 쿼리식으로 만드는 것 뿐 아니라 함수식으로 만들 수 있다.
         * 
         */
        static void Main(string[] args)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 1; i <= 30; i++)
            {
                dic.Add(i, i % 2);
            }

            var dic2 = new Dictionary<int, int>();
            for (int i = 18; i <= 45; i++)
            {
                dic2.Add(i, i % 2);
            }

            //SELECT FROM WHERE ORDER BY
            var results = dic.Where(x => x.Key > 5)
                        .OrderByDescending(x => x.Key)
                        .Select(x => x.Key);

            foreach (var result in results)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();

            //SELECT FROM WHERE INNER JOIN
            var results2 = dic.Where(x => x.Value.Equals(0))
                        .Join(dic2, x => x.Key, y => y.Key, (x, y) => y)    //dic2와 join한다.
                        .Select(x => x.Key);

            foreach (var result in results2)
            {
                Console.Write(result + " ");
            }
        }
    }
}
