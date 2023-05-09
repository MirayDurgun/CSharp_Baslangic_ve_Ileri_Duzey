using System;

namespace Ic_ice_for
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//
			Console.Clear();
			for(int i=1; i<=20;i++)
			{
				for(int j=1; j<=i;j++)
				{
					Console.Write("*");
				}
                Console.WriteLine();
            }
		}
	}
}
