using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Collection
{
    public class StackExam
    {
        public Stack<int> stack = new Stack<int>();

        public void test()
        {
            stack.Push(10); //push
            stack.Push(11);
            stack.Push(12);
            Console.WriteLine(stack.Pop()); //pop
            Console.WriteLine(stack.Pop());
        }
    }
}
