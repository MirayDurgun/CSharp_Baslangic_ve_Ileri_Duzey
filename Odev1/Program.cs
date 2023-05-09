using System;

namespace Odev1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1 - 100 arasındaki çift sayıların toplamı
			int toplam = 0;
			for (int i = 1; i <= 100; i++)
			{

				if (i % 2 == 0)
				{
					toplam += i;
				}
				
			}
            Console.WriteLine("Toplam = "+toplam);
        }
	}
}
