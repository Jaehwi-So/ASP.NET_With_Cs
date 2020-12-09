using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Delegate
{
    class MyArea : Form
    {
        //무명 메서드
        public MyArea()
        {
            this.MouseClick += delegate { MyAreaClicked(); };   //마우스로 클릭할 때 MyAreaClicked() 호출
        }

        public delegate void ClickDelegate(object sender);

        // Delegate 필드 : Delegate는 클래스의 필드나 속성에 사용될 수 있다.
        public ClickDelegate MyClick;
        //public ClickDelegate Click { get; set; }  //Delegate 속성


        // MyArea가 클릭되면 아래 함수가 호출된다고 가정
        void MyAreaClicked()
        {
            if (MyClick != null)
            {
                Console.Write("클릭하면 MyClick 델리게이트 메서드 호출");
                MyClick(this);
            }
        }
    }

    class Program
    {
        static MyArea area;

        static void area_click(object sender)
        {
            area.Text = "MyArea 클릭!";
        }

        static void Main(string[] args)
        {
            area = new MyArea();
            area.MyClick = area_click;
            area.ShowDialog();  //폼 보여주기
        }


    }
}
