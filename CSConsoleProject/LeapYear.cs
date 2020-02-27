using System;

namespace CSConsoleProject
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year to know Leap Year or NOT: ");

            int year = Int32.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        Console.WriteLine("Leap Year");
                    else
                        Console.WriteLine("NOT Leap Year");
                }
                else
                    Console.WriteLine("Leap Year");
            }
            else
                Console.WriteLine("NOT Leap Year");
        }
    }
}
