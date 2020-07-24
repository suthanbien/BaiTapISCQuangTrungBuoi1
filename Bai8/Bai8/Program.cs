using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("******** Bài 5 ********");
            Console.Write("nhap vao so n: ");
            n = Convert.ToInt32(Console.ReadLine().Trim());
            int[] arrThuan = new int[n.ToString().Count()];
            int[] arrNghich = new int[n.ToString().Count()];

            for (int i=0;i< n.ToString().Count();i++)
            {
                arrThuan[i] = Convert.ToInt32(n.ToString()[i].ToString());
            }

            for (int j = n.ToString().Count()-1; j>=0; j--)
            {
                arrNghich[j] = Convert.ToInt32(n.ToString()[n.ToString().Count() - 1-j].ToString());
            }


            if (KiemTra2MATran(arrThuan, arrNghich)==1)
            {
                Console.WriteLine("Day la so thuan nghich doc");
            }
            else
            {
                Console.WriteLine("Day khong phai la so thuan nghich doc");
            }


            Console.Read();

            int KiemTra2MATran(int[] arr1,int[] arr2)
            {
                int kq=0;
                for (int kt = 0; kt < arr1.Length; kt++)
                {
                    if (arr1[kt] != arr2[kt])
                    {
                        kq= 0;
                        break;

                    }
                    else {
                        kq= 1;
                        
                 }
                }

                return kq;

            }
        }
    }
}
