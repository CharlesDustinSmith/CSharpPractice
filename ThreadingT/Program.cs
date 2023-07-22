// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

namespace ThreadingE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxWorkerThreads, maxCompletionPortThreads;
            int availableWorkerThreads, availableCompletionPortThreads;

            ThreadPool.GetMaxThreads(out maxWorkerThreads, out maxCompletionPortThreads);
            ThreadPool.GetAvailableThreads(out availableWorkerThreads, out availableCompletionPortThreads);

            Console.WriteLine("Max worker threads: " + maxWorkerThreads);
            Console.WriteLine("Max completion port threads: " + maxCompletionPortThreads);
            Console.WriteLine("Available worker threads: " + availableWorkerThreads);
            Console.WriteLine("Available completion port threads: " + availableCompletionPortThreads);

            new Thread(() => {
                while(true)
                {
                    System.Console.WriteLine("Thread 1");
                    Thread.Sleep(3000);
                }
            }).Start();

            new Thread(() => {
                while(true)
                {
                    System.Console.WriteLine("Thread 2");
                    System.Console.WriteLine("");
                    Thread.Sleep(3000);
                }
            }).Start();            

            new Thread(() => {
                while(true)
                {
                    System.Console.WriteLine("Thread 3");
                    System.Console.WriteLine("");
                    Thread.Sleep(3000);
                }
            }).Start();

            new Thread(() => {
                while(true)
                {
                    System.Console.WriteLine("Thread 4");
                    System.Console.WriteLine("");
                    Thread.Sleep(3000);
                }
            }).Start();

            Console.ReadLine();
        }
    }
}