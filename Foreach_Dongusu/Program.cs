using System;

namespace Foreach_Dongusu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//foreach
			string[] isimler = new[] { "deniz", "miray", "umut", "hasan", "merve", "ali" };

			foreach (string item in isimler)
			{
				Console.WriteLine(item);
			}
		}

	}
}
