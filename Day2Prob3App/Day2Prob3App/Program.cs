using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Prob3App
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, a;
            Console.WriteLine("Enter your expected value:");
            value = Convert.ToInt32(Console.ReadLine());
            List<long> l=new List<long>();
            bool isPrime = true;
            int b= 0;
            for (int i = 2; i < value; i++)
            {
                if (value%i == 0)
                {
                    for (long j = 2; j < i; j++)
                    {
                        if (i%j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if(isPrime)
                        l.Add(i);

                }
            }
            Console.WriteLine(l.Max());
        }
    }
}
