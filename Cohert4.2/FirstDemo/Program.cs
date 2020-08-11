using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age : ");
            int age = int.Parse(Console.ReadLine());
  
            Console.WriteLine("Hello, " + name + " You are " + age + " old");
        }
    }
}
