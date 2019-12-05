using System;
using System.Threading;

namespace ThreadPoolLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.GetAvailableThreads(out int threads, out int ports);
            Console.WriteLine(threads);
            for(var i = 0; i < 20; i++)
            {
                ThreadPool.QueueUserWorkItem(ProcessNumbers);
            }
            Console.ReadLine();
            //Thread.CurrentThread.Join();
        }

        static void ProcessNumbers(object state)
        {
            var currentThread = Thread.CurrentThread;

            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine($"[{currentThread.ManagedThreadId}] - {i}");
                Thread.Sleep(500);
            }
        }
    }
}
