using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace GenericList_Inceleme
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> sayilarim = new List<int>();
			sayilarim.Add(1);
			//koleksiyona aynı anda birden fazla değer eklemek istediğimizde
			int[] eklenecekData1 = new int[4];
			eklenecekData1[0] = 2;
			eklenecekData1[1] = 6;
			eklenecekData1[2] = 4;
			eklenecekData1[3] = 5;
			//bu datayı sayilarim koleksiyonuna eklemek istiyorum;

			/*//1. ama uzun yol
			for (int i = 0; i < eklenecekData1.Length; i++)
			{
				sayilarim.Add(eklenecekData1[i]);
			}
			*/

			//2. ama kısa yol
			sayilarim.AddRange(eklenecekData1);
			// AddRange kendi veri tipine uygun koleksiyonları kabul etmekte 

			//-----------------------------------------------------------------------------------------------------



			/*ArrayList neydi?
			dizi ve arraylist farkı, Diziler sabit uzunluktadır. 
			Tanımlandıktan sonra değer atama, çıkarma işlemleri yapılamaz. 
			ArrayList'te ise böyle bir kısıtlama yoktur.
			
			Capacity
			koleksiyonun alabileceği maksimum değeri ifade eder
			4'er artar kapasite
			count
			koleksiyonun içindeki var olan değer sayısını ifade eder
			*/
			//Capacity değerşmşn Count kadar olmasını istiyorum dersek;
			sayilarim.TrimExcess();
			int capacity = sayilarim.Capacity;
			int count = sayilarim.Count;
			//bu şekilde kodlarsak count ve capacity değerleri eşitlenir

			//ekrana yazdırmak için 1. yol
			for (int i = 0; i < sayilarim.Count; i++)
			{
				Console.WriteLine(sayilarim[i]);
			}

			//ekrana yazdırmak için 2.yol
			sayilarim.ForEach(i => Console.WriteLine(i));
			//sayilarım koleksiyonu içinde foreach yaptık
			//i => Console.WriteLine(i)
			//i şunu işaret eder, koleksiyon içerisindeki her bir değere ulaşırken 
			//i değeri ile ulaşırız

			//=> lambda işaretidir;
			//linq konusudur
			//ilgili koleksiyon içerisinde arama yapar

			//**************************************************
			//Linq konusunda işlecek
			int bulunanDeger = sayilarim[3];
			Console.WriteLine("List <T> koleksiyonu içindeki 3. Index'te bulunan değer = {0}", bulunanDeger);

			sayilarim.Insert(3, 100);
			//3. indexe 100 değerini ekler

			bool kontrol1 = sayilarim.Any();
			bool kontrol2 = sayilarim.Any(i => i > 5); //koleksiyon içinde 5ten büyük değer varsa true dön yoksa false dön

			//koleksiyonlarımızı sıralayabiliriz
			//büyükten küçüğe veya küçükten büyüğe
			sayilarim.Sort();//A->Z'ye & 1->N'e doğru sıralar
			sayilarim.Reverse(); //Z->A'ya & N->1'e doğru sıralar

			//dizi içinden eleman kaldırma
			bool silmeSonuc = sayilarim.Remove(100); //100 değerini siler
			int silinenAdet = sayilarim.RemoveAll(i => i > 3); //belirtmiş olduğumuz değerlere karşılık gelen değerleri siler
															   //3ten büyük olan değerleri siler

			sayilarim.RemoveAt(2); //2. Indexte bulunan değeri siler
			sayilarim.Clear(); //koleksiyon içindeki bütün değerleri siler


		}
	}
}
