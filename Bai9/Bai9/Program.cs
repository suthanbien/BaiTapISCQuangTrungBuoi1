using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("******** Bài 9 ********");
            Console.Write("nhap vao so n: ");
            n1 = Convert.ToInt32(Console.ReadLine().Trim());
            int[] arr = new int[n1];
            quayLui(0, n1, arr);



            void quayLui(int i, int n, int[] X)
            {
                int val;    // val la cac gia tri co the gan cho cac vi tri trong X
                for (val = 0; val < 2; val++)      // val co the nhan hai gia tri la : 0 va 1
                {
                    X[i] = val;
                    if (i == (n - 1))         // neu i la phan tu cuoi cua day
                    {
                        int j;
                        for (j = 0; j < n; j++)         // in ra day so nhi phan moi tim duoc
                        {
                            Console.Write(X[j]+" ");
                        }
                        Console.WriteLine("");
                    }
                    else              // neu i chua phai phan tu cuoi thi ta se gan gia tri cho phan tu sau i.
                    {
                        quayLui(i + 1, n, X);
                    }
                }
            }
            Console.Read();

        }

       

    }
}
