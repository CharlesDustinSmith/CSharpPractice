// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

namespace ThreadingTpt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();

            Thread thread = new Thread(() => {
                System.Console.WriteLine("Thread number: {0} started", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(3000);
                taskCompletionSource.TrySetResult(true);
                System.Console.WriteLine("Thread number: {0} ended", Thread.CurrentThread.ManagedThreadId);
            });

            thread.Start();
            var test = taskCompletionSource.Task.Result;
            System.Console.WriteLine("Task was done: {0}", test);
        }
    }
}
