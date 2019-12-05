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
            ThreadPool.QueueUserWorkItem(ProcessNumbers);
            Thread.CurrentThread.Join();
        }

        static void ProcessNumbers(object state)
        {
            var currentThread = Thread.CurrentThread;

            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine($"[{currentThread.ManagedThreadId}] - {i}");
                Thread.Sleep(100);
            }
        }
    }
}
