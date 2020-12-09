using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Collection
{
    public class QueueExam
    {
        public Queue<int> queue = new Queue<int>();

        public void test()
        {
            queue.Enqueue(10);  //enqueue
            queue.Enqueue(11);
            queue.Enqueue(12);
            Console.WriteLine(queue.Dequeue()); //dequeue
            Console.WriteLine(queue.Dequeue());
        }
    }
}
