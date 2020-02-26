using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleProject
{
    class Factors
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find the factors: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Factors of number {0} are ", num);

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
