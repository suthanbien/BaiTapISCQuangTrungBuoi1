using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("******** Bài 6 ********");
            Console.Write("nhap vao so n: ");
            n = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine(n+" dau tien la:");
            int dem=0, dem2 = 0;
            while (dem2 < n)
            {
                if (checkSNT(dem)==1)
                {

                    Console.Write(dem+" ");
                    dem2 += 1;
                }
                dem++;
            }
           

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



            Console.Read();
        }
        
    }
}
