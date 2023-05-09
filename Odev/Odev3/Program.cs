using System;

namespace Odev3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1-10 çarpım tablosu
			for (int i = 1; i <= 10; i++)
			{
				for (int j = 1; j <= 10; j++)
				{
					int carpim = i * j;
					Console.WriteLine("{0} x {1} = {2}", i, j, carpim);
				}
				Console.WriteLine("--------------");
			}
		}
	}
}
