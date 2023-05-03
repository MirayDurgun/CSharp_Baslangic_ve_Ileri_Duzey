using System;
using System.Security.Cryptography;

namespace IS_Operatoru
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int s1 = 50;
			object o1 = s1;
			Console.WriteLine(o1);
			s1 = (int)o1;
			//is ayrım için kullanılır

			//is operatorü
			//bool donenDeger=degisken is desgisken tipi
			bool degiskenKontrol = o1 is int;
			//o1 int mi?
			bool degiskenKontrol2 = o1 is byte;
			//o1 içindeki değişken tipine bakar 
		}
	}
}
