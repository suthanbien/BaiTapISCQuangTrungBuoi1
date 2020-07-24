using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int soA, soB;
            Console.WriteLine("******** UCLN, BCNN ********");
            Console.Write("nhap so a:");
            soA = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so b:");
            soB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("UCLN la: "+ UCLN(soA,soB));
            Console.WriteLine("BCNN la: "+ BCNN(soA,soB));

            Console.ReadLine();


             int UCLN(int a, int b)
            {
                while (a != b)
                {
                    if (a > b)
                        a = a - b;
                    else
                        b = b - a;
                }
                return a;
            }

             int BCNN(int a, int b)
            {
                int result = UCLN(a, b);
                return a * b / result;
            }
        }
    }

}
