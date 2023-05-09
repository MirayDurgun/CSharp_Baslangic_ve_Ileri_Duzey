using System;

namespace while_dongusu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region genel kullanım
			/*	while(true)
					//şart true olduğu süre boyunca
					//döngü çalışmaya devam eder

				{

				}*/
			#endregion

			#region ornek

			//1 - 10 sayı değeri yazdırma
			int sayac = 0;
			while(sayac<10)
			{
				sayac++;
                Console.WriteLine(sayac);
            }
			#endregion

		}
	}
}
