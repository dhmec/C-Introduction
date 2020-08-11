using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            Console.WriteLine("please enter first interger number : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second integer number : ");
            int b = int.Parse(Console.ReadLine());

            double sum = (long)a * (long)b;
  
            Console.WriteLine(" Multiplication of " + a + " and " + b + " is : " + sum );
        }
    }
}
