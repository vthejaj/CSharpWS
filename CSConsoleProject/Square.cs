using System;

namespace CSConsoleProject
{
    class Square
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Square of {0} is {1}", num, num * num);
        }
    }
}
