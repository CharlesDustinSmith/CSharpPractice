// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

namespace ThreadJoiningE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Main Thread started");
            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();
            
            // thread1.Join();
            // System.Console.WriteLine("Thread1 Function done");
            if(thread1.Join(1000))
            {
                System.Console.WriteLine("Thread1 Function done");
            }
            else
            {
                System.Console.WriteLine("Thread1Function wasn't done within 1 second");
            }

            thread2.Join();
            System.Console.WriteLine("Thread2 Function done");

            for(int i = 0; i < 10; ++i)
            {
                if(thread1.IsAlive)
                {
                    System.Console.WriteLine("Thread1 is still doing stuff.");
                    Thread.Sleep(300);
                }
                else
                {
                    System.Console.WriteLine("Thread1 completed.");
                }
            }

            System.Console.WriteLine("Main Thread ended");
        }

        public static void Thread1Function()
        {
            System.Console.WriteLine("Thread1Function started");
            Thread.Sleep(3000);
            System.Console.WriteLine("Thread1 Function coming back to main");
        }

        public static void Thread2Function()
        {
            System.Console.WriteLine("Thread2Function started");
            Thread.Sleep(3000);
            System.Console.WriteLine("Thread2 Function coming back to main");

        }
    }
}
