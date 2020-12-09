using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface
{
    public class Member
    {
        //다음과 같이 getter와 setter를 설정하면 
        //protected string name;
        //private Name
        //{
            //get{..}
            //set{..}
        //} 와 같다.

        protected string Name { get; set; } //private으로 선언 시 자식 클래스에서 필드를 사용할 수 없다. 따라서 protected로 선언
        protected string Age { get; set; }
        public Member(string name, string age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
