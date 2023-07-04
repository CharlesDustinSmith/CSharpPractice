using System;

namespace VarKeyword
{
    class HelloMaker
    {
        public void Greet()
        {
            var maker = 29;
            var name0 = "Charles Dustin Smith";
            
            System.Console.WriteLine("Hello my name is {0}, and my age is {1}", name0, maker);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var name = "Charles";
            var age = 25;
    
            HelloMaker x = new HelloMaker();
            x.Greet();
    
            System.Console.WriteLine("Hello my name is {0}, my age is {1}.", name, age);
        }
    }

}




