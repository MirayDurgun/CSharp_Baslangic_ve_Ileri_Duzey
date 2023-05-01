using System;

namespace OzelOperatorler
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// Mod alma operatörü %
			//kalanı bulur
			int s1 = 11;
			int s2 = 2;
			int sonucMod = s1 % s2;
            Console.WriteLine(sonucMod);

            // ++ operatörü 
            //1 arttırır
            int s3 = 10;
			int OperatorSonucI = s3++;
			int OperatorSonucII = ++s3;
            //int OperatorSonucI = s3 + 1;
            Console.WriteLine(OperatorSonucI);
            Console.WriteLine(OperatorSonucII);

            // -- operatörü 
            //1 eksiltir
            int s4 = 10;
			//int OperatorSonucIII = s4--;
			int OperatorSonucVI = --s4;
			Console.WriteLine(OperatorSonucVI);
		}
	}
}
