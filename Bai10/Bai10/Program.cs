using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,k1;
            Console.WriteLine("******** Bài 10 ********");
            Console.Write("nhap vao so n: ");
            n1 = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("nhap vao so k: ");
            k1 = Convert.ToInt32(Console.ReadLine().Trim());


            int[] X2=new int[k1 + 1];

            quayLui(n1, k1, X2, 1);


            Console.Read();

            void quayLui(int n, int k, int[] X, int i)
            {
                int j;
                for (j = X[1] + 1; j <= n - k + i; j++)
                {
                    X[i] = j;

                    if (i == k)
                    {
                        int temp;
                        for (temp = 1; temp <= k; temp++)
                        {
                            Console.Write("  "+ X[temp]);
                        }
                        Console.WriteLine("");
                    }
                    else
                    {
                        quayLui(n, k, X, i + 1);
                    }
                }
            }
        }
    }
}
