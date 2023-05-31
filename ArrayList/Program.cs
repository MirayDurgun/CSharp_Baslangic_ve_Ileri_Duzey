using System;
using System.Collections;

namespace ArrayList_kolaeksiyon
{
	internal class Program
	{
		static void Main(string[] args)
		{

			/*dizi ve arraylist farkı
			 Diziler sabit uzunluktadır. 
			Tanımlandıktan sonra değer atama, 
			çıkarma işlemleri yapılamaz. 
			ArrayList'te ise böyle bir kısıtlama yoktur.
			*/
			int Capacity = 0;
			int Count = 0;

			string[] isimller = new string[10];
			ArrayList A1 = new ArrayList();

			Capacity = A1.Capacity;
			//koleksiyonun alabileceği maksimum değeri ifade eder
			//4'er artar kapasite
			Count = A1.Count;
			//koleksiyonun içindeki var olan değer sayısını ifade eder

			//tek değer ekleme
			A1.Add("a");
			//add metodu arraylistin içerisine sadece 1 değer eklememize yarar
			A1.Add(160);


			//birden çok değer ekleme

			ArrayList B1 = new ArrayList();
			B1.AddRange(isimller);
			B1.Add("Merve");
			B1.Add("Melis");
			B1.Add("Melih");
			A1.AddRange(B1);

			Capacity = A1.Capacity;
			Count = A1.Count;
		}
	}
}
