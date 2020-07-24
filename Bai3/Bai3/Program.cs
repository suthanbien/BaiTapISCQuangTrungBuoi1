using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String chuoi = "";
            int tong=0;
            Console.WriteLine("******** Bài 3 ********");
            Console.Write("nhap vao chuoi so: ");
            chuoi = Console.ReadLine().Trim();
            for (int i=0;i<chuoi.Count();i++)
            {
                int so = Convert.ToInt32(chuoi[i].ToString());
              //  Console.WriteLine("tong cac chu so la: " + so);
                tong = tong + so;
            }

            Console.WriteLine("tong cac chu so la: "+tong);
            Console.Read();
        }
    }
}
