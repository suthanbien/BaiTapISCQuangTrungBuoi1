using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n=0, heSo=0, soDu = 0;
			String chuoi = "";

			Console.WriteLine("******** Bài 2 ********");
            Console.Write("nhap so bat ky:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap he so muon chuyen (1< b≤ 36):");
            heSo = Convert.ToInt32(Console.ReadLine());
		
			char[] doiso = new char[n] ;
			int i = 0;
			while (n > 0)
			{
				soDu = n % heSo;
				if (soDu < 10)
				{
					doiso[i] =Convert.ToChar(48 + soDu);
				}
				else
				{
					doiso[i] =Convert.ToChar(65 + (soDu - 10));
				}
				i++;
				n = n / heSo;

			}
			for (int a = doiso.Count()-1; a >= 0; a--)
			{
				if (doiso[a]!='\0')
				{
					chuoi += doiso[a].ToString();
				}
			}
			Console.WriteLine("ket qua khi doi he so " + heSo);
			Console.WriteLine(chuoi);
			Console.ReadLine();	
			
		}
    }
}
