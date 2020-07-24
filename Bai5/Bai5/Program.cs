using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;

            Console.WriteLine("******** Bài 5 ********");
            Console.Write("nhap vao so n: ");
            n = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("cac so nguyen to nho hon "+n+" la:");
            if (n >= 2)
            {
                Console.Write(2);
            }
            for (int i = 3; i < n; i += 2)
            {
                if (checkSNT(i) == 1)
                {
                    Console.Write(" "+ i);
                }
            }
            Console.Read();
            int checkSNT(int snt)
            {
                // so nguyen n < 2 khong phai la so nguyen to
                if (snt < 2)
                {
                    return 0;
                }
                // check so nguyen to khi n >= 2
                int i;
                int squareRoot = (int)Math.Sqrt(snt);
                for (i = 2; i <= squareRoot; i++)
                {
                    if (snt % i == 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }
        }
    }
}
