using System;

namespace Local_Function
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//metotlarımızın içinde metotlar tanımlayabiliriz local functionun görevi budur
			//metot içine özel metot tanımlanır

			localfunctionkullanim(15, 60);
			//topla metoduna erişemeyiz çünkü bu metot ancak yazıldığı metot içinde çağırılıp kullanılabilir
		}
		static void localfunctionkullanim(int sayi1, int sayi2)
		{
			//bu metota özel metot tanımlayalım
			int topla(int gelensayi1, int gelensayi2)
			{
				return gelensayi1 + gelensayi2;
			}
			int toplamdeger = topla(sayi1, sayi2);
			Console.WriteLine(toplamdeger);
		}
	}
}
