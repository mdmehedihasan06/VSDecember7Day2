using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Prob2App
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, c, d=0;
            Console.WriteLine("Enter lower limit:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper limit:");
            max = Convert.ToInt32(Console.ReadLine());
            int a = min, b = min + 1;
            //Console.WriteLine("{0}", a);
            //Console.WriteLine("{0}", b);
            for (int i = min; i < max; i++)
            {
                c = a + b;
                a = b;
                b = c;
                if (c < max)
                {
                    if (c%2==0)
                    {
                        d=d + c;
                        Console.WriteLine("{0}", d);
                        //Console.ReadLine();
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
