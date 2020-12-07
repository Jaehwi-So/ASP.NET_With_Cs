using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Class
{
    class ExamClass
    {
        /* # 멤버변수(필드) # */
        private int age;
        private string name;
        /* 접근 제한자
        public 모든 외부(파생클래스 포함)에서 이 타입(Type: 클래스, 구조체, 인터페이스, 델리게이트 등)을 엑세스할 수 있다. (개별 타입 멤버의 엑세스 권한은 해당 멤버의 접근 제한자에 따라 별도로 제한될 수 있다)internal 동일한 Assembly 내에 있는 다른 타입들이 엑세스 할 수 있다.하지만, 다른 어셈블리에서는 접근이 불가하다.
        protected 파생클래스에서 이 클래스 멤버를 엑세스할 수 있다.
        private 동일 클래스/구조체 내의 멤버만 접근 가능하다.
        */

        /* # 이벤트 # */
        public event EventHandler NameChanged;

        /* # 생성자 # */
        public ExamClass(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        /* # 속성 # */
        // 속성은 클래스의 내부 데이터를 외부에서 사용할 수 있게 하거나 외부에서 클래스 내부의 데이터를 간단하게 설정할 때 사용한다.
        // getter와 setter은 다음과 같은 방식으로 설정할 수 있다.
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    if (NameChanged != null)
                    {
                        NameChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        /* # 메서드 # */
        public void getInfo()
        {
            Console.WriteLine("이름 : " + this.name + " 나이 : " + this.age);
        }


    }
}
