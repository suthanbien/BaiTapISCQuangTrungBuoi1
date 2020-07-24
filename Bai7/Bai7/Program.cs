using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("******** Bài 5 ********");
            Console.Write("nhap vao so n: ");
            n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write( "So Fibonacci thu " + n + " la: " + CheckFibonacci(n));


            Console.Read();
            int CheckFibonacci(int f)
            {
                if (f == 1 || f == 2)
                    return 1;
                return CheckFibonacci(f - 1) + CheckFibonacci(f - 2);
            }
        }
    }
}
