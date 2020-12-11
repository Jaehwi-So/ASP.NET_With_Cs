using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _30_Async_Await
{
    class Program
    {
        //async 키워드를 가지면 1개 이상의 비동기 처리 await을 가질 수 있다.
        private async void Run(int times)
        {
            //비동기로 Worker Thread에서 도는 task
            var task = Task.Run(() => Calc(times));    //Run()이라는 async 메서드.

            //SynchronizationContext : UI 프로그램의 경우 await가 실행되기 전에 실행되고 있던 스레드를 캡처해서 저장한다. 
            //그렇지만 콘솔에서는 디폴트가 null이어서 await 이후 문자을 실행할 때 스레드풀에서 스레드를 가져와 실행한다.

            Console.WriteLine("syncContext" + SynchronizationContext.Current); // 콘솔프로그램인 경우 SynchronizationContext가 null
            int sum = await task;   //await은 일반적으로 Task, Tack<T> 객체와 함께 사용된다.
            Console.WriteLine("sum " + sum + " cur thread : " + Thread.CurrentThread.ManagedThreadId);//작업 스레드 확인
        }

        //Task.ContinueWith() : await와 같은 개념. 
        private void Run2(int times)
        {
            //비동기로 Worker Thread에서 도는 task
            var task = Task.Run(() => Calc(times));    //Run()이라는 async 메서드.

            Console.WriteLine("syncContext" + SynchronizationContext.Current); 
            task.ContinueWith(x =>
            {
                Console.WriteLine("sum " + task.Result + " cur thread : " + Thread.CurrentThread.ManagedThreadId);//작업 스레드 확인
            });
        }

        private int Calc(int times)
        {
            int result = 0;
            for (int i = 0; i < times; i++)
            {
                result += 1;
                Console.WriteLine(result);
                Thread.Sleep(1000);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run(10);
            p.Run(20);
            p.Run2(30);
            Console.ReadLine();
        }
    }
}
