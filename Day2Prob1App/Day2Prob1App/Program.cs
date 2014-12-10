using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Prob1App
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, a=0, b=0, c, d;
            Console.WriteLine("Enter min range:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max range:");
            max = Convert.ToInt32(Console.ReadLine());
            for (int i = min; i < max; i++)
            {
                if (i%3==0)
                {
                    a = a+i;
                }   
                else if (i%5==0)
                {
                    b = b+i;
                }
            }
            c = a + b;
            Console.WriteLine("The sum result is:{0}", c);
        }
    }
}
