using System;

namespace Continue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//continue= şart sağlandığında ve continuse çalıştığında
			//1 seferliğine aşağıda bulunan kod bloğunu çalıştırmaz
			int sayac = 0;
			for (; ; )
			{
				sayac++;
				if (sayac == 2)
					continue;
				else
					Console.WriteLine(sayac);
			}


		}
	}
}
