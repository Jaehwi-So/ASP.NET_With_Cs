using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Delegate를 통해 이벤트를 처리할 시 할당 연산자의 잘못된 사용으로 기존의 모든 메서드 리스트들을 이벤트에서 지워버릴 여지가 있다.
 * 또한 해당 클래스 내부에서가 아닌 외부에서도 누구라도 메서드를 호출하듯 해당 Delegate를 호출할 수 있었다.
 * 따라서 특수한 형태의 Delegate인 Event를 사용한다.
 * Event는 할당 연산자를 사용할 수 없으며 오직 이벤트 핸들러의 추가나 삭제만을 할 수 있다.
 * 또한 해당 클래스 외부에서는 직접 이벤트를 호출할 수 없다.
 * */
namespace _23_Event_Delegate
{
    class MyArea : Form
    {
        public delegate void ClickEvent(object sender);
        public MyArea()
        {
            this.MouseClick += delegate { MyAreaClicked(); };
        }
        // event 필드
        public event ClickEvent MyClick;

        // 폼 클릭이벤트 발생 시 MyClick 메서드 호출
        void MyAreaClicked()
        {
            if (MyClick != null)
            {
                MyClick(this);
            }
        }
    }

    class Program
    {
        static MyArea area;

        //이벤트 발생 시 수행할 로직
        static void click1(object sender)
        {
            area.Text += " click1 ";
        }

        static void click2(object sender)
        {
            area.Text += " click2 ";
        }

        static void Main(string[] args)
        {
            area = new MyArea();

            // 이벤트 핸들러 추가
            area.MyClick += click1;
            area.MyClick += click2;

            // 이벤트 핸들러 제거
            area.MyClick -= click1;

            //area.MyClick(this); //이벤트를 직접 호출하는 것은 불가능하다.

            area.ShowDialog();
        }


    }
}
