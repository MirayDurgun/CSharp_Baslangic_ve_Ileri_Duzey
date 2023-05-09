using System;

namespace For_Dongu
{
	internal class Program
	{
		static void Main(string[] args)
		{

			/* for (sayaç; şart; sayaç artış işlemi;)
			 * {tekrar edilecek kodlar}
			 */

			#region for döngüsü genel kullanım
			//0'dan 10'a kadar sayar

			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine(i);
			}

			#endregion

			#region 1 - 100 arasındaki çift sayıları yazdırma

			for (int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
					Console.Write(i+ ",");
				}

			}

			#endregion


		}
	}
}
