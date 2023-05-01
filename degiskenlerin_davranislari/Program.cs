using System;

namespace degiskenlerin_davranislari
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string degiskenVal1 = "Miray Durgun";
			string degiskenVal2 = "Melih Durgun";
			//değerleri değişğkenlerin içine attık 

			degiskenVal1 = degiskenVal2;
			//degiskenVal2'nin değerini degiskenVal1'e ata
			//bu işlem sonrasında degiskenVal1'in değeri de Melih Durgun olur
		
			degiskenVal2 = "Can Durgun";
			//sonrasında 2. değişkenin değerini değiştirince değişken 1 bundan etkilenmez

		}
	}
}
