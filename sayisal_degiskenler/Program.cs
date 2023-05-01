using System;

namespace sayisal_degiskenler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int ve byte
			byte deger1 = 10;
			//byte alabileceği min ve max değer vardır
			//nasıl öğreniriz?
			byte byteMinVal = byte.MinValue;
			byte byteMaxVal=byte.MaxValue;

			int deger2 = 100;
			//int alabileceği min ve max değer vardır
			//nasıl öğreniriz?
			int intMinVal=int.MinValue;
			int intMaxVal=int.MaxValue;

			Console.WriteLine(byteMinVal);
            Console.WriteLine(byteMaxVal);
            Console.WriteLine(intMinVal);
            Console.WriteLine(intMaxVal);
        }
	}
}
