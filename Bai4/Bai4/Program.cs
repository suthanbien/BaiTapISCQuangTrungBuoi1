using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int soNguyen = 0,  dem;

            Console.WriteLine("******** Bài 4 ********");
            Console.Write("nhap vao chuoi so: ");
            soNguyen = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 2; i <= soNguyen; i++)
            {
                bool check = false;
                dem = 0;
                while (soNguyen % i == 0)
                {
                    check = true;
                    ++dem;
                    soNguyen /= i;

                    if (check)
                    {
                        Console.Write(i);
                        if (soNguyen >= i)
                        {
                            Console.Write(" * ");
                        }
                    }

                }




            }

            Console.Read();
        }
    }
}
