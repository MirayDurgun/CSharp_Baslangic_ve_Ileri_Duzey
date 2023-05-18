using System;
using System.Collections;

namespace ArrayList_koleksiyon2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int Capacity = 0;
			int Count = 0;

			//arraylistin içindeki bir elemana nasıl ulaşıp değiştirebiliriz
			string[] isimller = new string[10];
			ArrayList A1 = new ArrayList();

			A1.Add("a");
			A1.Add(160);


			ArrayList B1 = new ArrayList();
			B1.Add("Merve");
			B1.Add("Melis");
			B1.Add("Melih");
			A1.AddRange(B1);

			//****************************************
			//koleksiyon içindeki değere ulaşmak
			object O1 = A1[3];
			string S1 = A1[3].ToString();
			//stringe çevirdik

			//int S2 = (int)A1[1];//int bool vs için kullanılır
								//bilinçsiz dönüşümdür
								//yani 2de bulunan değer string olursa hata fırlatır

			//******************************************
			//koleksiyon içerisindeki değeri değiştirmek
			A1[3] = "Miray";

			//*************************************************

			A1.Sort();//sıralama A-Z
			A1.Reverse();   //mevcut elemanları ters olarak sıralar

			//*************************************************
			//koleksiyonlar yardımcı komutları
			int indexDeger = A1.IndexOf("Merve");   //koleksiyonun içindeki değerlerin hangi indexte olduğunu
													//bilmediğimiz durumlarda
													//index değerini bulmak için kullanılır
			A1.Remove(indexDeger);  //bulduğumuz kişinin index değerini silebiliriz



			object[] Dizi = A1.ToArray(); //Arrayde bulunan tüm dataları dizi olarak verir

			A1.Clear();     //A1'in içinde ne varsa siler
							//fakat hiç değer olmamasına rağmen kapasiteyi tutar bunun içinde;
			A1.TrimToSize();//kullanılır kapasiteyi ilk oluşan 4 değerine geri çeker

			bool kontrol1 = A1.Contains("deneme");
			bool kontrol2 = A1.Contains("Melis");//ilgili koleksiyon içerisinde girilen değeri arar(deneme) 
												 //bulursa true verir bulamazsa false verir.


			//********************************************
			//koleksiyon içinden değer silme
			A1.Remove("Miray"); //A1 içindeki Miray değerini sil
			A1.RemoveRange(2, 3);//a1 içinde bulunan bir başlangıç indexi ver
								 //kısaca (2, 3); bu ifade 2. indexten başla 3 eleman sil demek
			A1.RemoveAt(2); //2. index'teki değeri siler

			Capacity = A1.Capacity;
			Count = A1.Count;

		}
	}
}
