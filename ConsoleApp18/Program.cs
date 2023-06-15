using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a n:");
            int n = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += calc(i);
            }
            Console.WriteLine("the sum is:" + result);
            Console.ReadKey();
        }

        static double calc(int n)
        {
            if(n==1)
            {
                return 0.5;
            }
            else
            {
                return (double)n / (Math.Pow(n, 2) + calc(n - 1));
            }
        }
    }
}
