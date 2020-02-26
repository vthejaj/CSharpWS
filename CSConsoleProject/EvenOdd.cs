using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleProject
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to know its Even or Odd:");
            int num = Int32.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}
