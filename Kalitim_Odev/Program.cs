using System;

namespace Kalitim_Odev
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Bilgisayar B1 = new Bilgisayar();
			//B1.id = 1;  //id değerini girmek istemiyorum, uygulamanın bu alanı bana set edilebilir bırakmasını da istemiyorum
			//yani idye değer girince hata versin, değer girmeyince de
			//id değerini takip edip bir sonraki id değerini alsın
			//bunun için
			B1.marka = "HP";
			B1.model = "Pavilion";
			B1.islemci = "ryzen5";
			B1.alisFiyat = 10000;
			B1.satisFiyat = 15000;
			B1.kampanyaFiyat = 700;
			B1.barkod = "12345hp";
			B1.barkod = "12000345hp";


			Bilgisayar B2 = new Bilgisayar();
			B2.marka = "HP";
			B2.model = "Pavilion";
			B2.islemci = "ryzen5";
			B2.alisFiyat = 10000;
			B2.satisFiyat = 15000;
			B2.kampanyaFiyat = 700;
			B2.barkod = "12345hp";
			B2.barkod = "12000345hp";



			Televizyon T1 = new Televizyon();
			//T1.id = 1;
			T1.marka = "Vestel";
			T1.model = "a254";
			T1.ekranBoyutu = "120";
			T1.alisFiyat = 1500;
			T1.satisFiyat = 2500;


			SanalDatabase.yeniUrunEkle(B1);

		}
	}
}
