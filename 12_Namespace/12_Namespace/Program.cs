using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//.NET 프레임워크는 무수하게 많은 클래스들을 가지고 있다. 클래스들을 충돌없이 편리하게 관리, 사용하기 위해 네임스페이스를 사용한다.
//따라서 클래스들은 대개 네임스페이스 안에서 정의된다.
namespace _12_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //네임스페이스 참조 방식

            //1. 클래스명 앞에 네임스페이스 전부를 적는 경우
            System.Console.WriteLine("Hello world");

            //2. using을 사용하여 사용하고자 하는 네임스페이스를 설정한 후 네임스페이스 없이 클래스를 사용
            Console.WriteLine("Hello world");
        }
    }
}
