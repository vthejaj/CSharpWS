using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleProject
{
    class LargestNum
    {
        //run this from command prompt and pass series of numbers
        static void Main(string[] args)
        {
            int num, big = 0;
            foreach (string e in args)
            {
                num = Int32.Parse(e);

                if (num > big)
                {
                    big = num;
                }
            }
            Console.WriteLine("Biggest of numbers is {0}", big);
        }
    }
}
