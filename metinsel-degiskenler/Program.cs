using System;

namespace metinsel_degiskenler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string isimSoyisim = "Miray Durgun";
            Console.WriteLine(isimSoyisim);
			
			string buyukKarakter=isimSoyisim.ToUpper();
			//hepsini büyük yazar
			string kucukKarakter=isimSoyisim.ToLower();
			//hepsini küçük yazar
			string belirliBolum = isimSoyisim.Substring(2, 5);
            //ray (boşluk) D karakterini yazdırır. 2. indexle 5. index arasındaki hafrleri alır
            Console.WriteLine(buyukKarakter);
            Console.WriteLine(kucukKarakter);
            Console.WriteLine(belirliBolum);
        }
	}
}
