using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Linq 쿼리식 : Collection 형식의 데이터를 데이터베이스 쿼리식 형태로 조회하여 가독성과 생산성을 높인다.
 */
namespace _31_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<int, int>();
            for(int i = 1; i <= 30; i++)
            {
                dic.Add(i, i % 2);
            }
            var dic2 = new Dictionary<int, int>();
            for (int i = 18; i <= 45; i++)
            {
                dic2.Add(i, i % 2);
            }

            //SELECT FROM WHERE ORDER BY
            var results = from item in dic
                          where item.Key > 5
                          orderby item.Key descending
                          select item.Key; //key가 5초과인 키값을 내림차순으로 출력
            foreach (var result in results)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();


            //SELECT FROM WHERE INNER JOIN
            var results2 = from item in dic
                          join item2 in dic2 on item.Key equals item2.Key into joindata // dic에서 dic2와 join하여 결과 값을 joindata로 한다.
                          from item3 in joindata // joindata의 각 아이템 값은 item3으로 한다.
                          where item.Value.Equals(0) //join한 값들 중 짝수 선택
                          select item3.Key;   //joindata 선택

            foreach (var result in results2)
            {
                Console.Write(result + " ");
            }


        }
    }
}
