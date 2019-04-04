using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();
            Task<int> t2 = new Task<int>(MyThread);
            Task t3 = new Task(() => { Thread.Sleep(500); Console.WriteLine("t3 finish"); });

            //t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Main thread continue... {0}, {1}", t2.Status, t3.Status);
            Thread.Sleep(1000);

            Task.WaitAll(t2, t3);
            Console.WriteLine(t2.Result);

            Console.WriteLine("Main thread 1 sec... {0}, {1}", t2.Status, t3.Status);
            Thread.Sleep(1000);

            Console.WriteLine("Main thread 2 sec... {0}, {1}", t2.Status, t3.Status);
            Thread.Sleep(1000);

            Console.WriteLine("Main thread 3 sec... {0}, {1}", t2.Status, t3.Status);

        }

        private static async void NewMethod()
        {
            Task<int> t1 = new Task<int>(MyThread);
            t1.Start();
            int x = await t1;
        }

        public static int MyThread()
        {
            Console.WriteLine("MyThread [{0}]: Starting...", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("MyThread [{0}]: Complete", Thread.CurrentThread.ManagedThreadId);
            return Thread.CurrentThread.ManagedThreadId;
        }
    }
}
