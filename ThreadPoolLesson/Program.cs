using System;
using System.Threading;

namespace ThreadPoolLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer(ProcessNumbers, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
            Console.ReadLine();
        }

        static void ProcessNumbers(object state)
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToLongTimeString()); 
            //var currentThread = Thread.CurrentThread;

            //for (var i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"[{currentThread.ManagedThreadId}] - {i}");
            //    Thread.Sleep(200);
            //}
            //Console.WriteLine($"[{currentThread.ManagedThreadId}] закончил считать");
        }
    }
}
