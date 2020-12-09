using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayListExam ex1 = new ArrayListExam();
            ListTExam ex2 = new ListTExam();
            StackExam ex3 = new StackExam();
            QueueExam ex4 = new QueueExam();
            HashTableExam ex5 = new HashTableExam();
            DictionaryExam ex6 = new DictionaryExam();


            ex1.test();
            ex2.test();
            ex3.test();
            ex4.test();
            ex5.test();
            ex6.test();
        }
    }
}
