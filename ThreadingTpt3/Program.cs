// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using System.Linq;

namespace ThreadingTpt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A Thread that runs in the background
            new Thread(() => {
                Thread.Sleep(2000);
                System.Console.WriteLine("Thread 4\n");
            })
            { IsBackground = true }.Start();

            // The ThreadPool example 
            Enumerable.Range(0, 100).ToList().ForEach(f => {

                ThreadPool.QueueUserWorkItem((o) => 
                {
                    System.Console.WriteLine("Thread number: {0} started", Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(3000);
                    System.Console.WriteLine("Thread number: {0} ended", Thread.CurrentThread.ManagedThreadId);                       
                });

                Console.ReadLine();

                new Thread(() => {
                    System.Console.WriteLine("Thread number: {0} started", Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(3000);
                    System.Console.WriteLine("Thread number: {0} ended", Thread.CurrentThread.ManagedThreadId);                
                }).Start();
            });


        }
    }
}
