using System;
using System.Collections;

namespace HashTable1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Hashtable ht = new Hashtable();
			//key ve value değerleri ile beslenir
			ht.Add("Car", "Araba"); //eklediğimizde parantez içinde bizden iki farklı değer ister
									//key ve value olarak
			ht.Add("House", "Ev");  //key değeri house value değeri ev'dir

			bool kontrol = ht.Contains("House"); //true döner
			bool kontrol2 = ht.Contains("H2ouse");//false döner

			bool kontrol3 = ht.ContainsKey("Car"); //containsle aynıdır ikisi de key değerine bakar
			bool kontrol4 = ht.ContainsValue("Ev"); //value değerine bakar

			int koleksiyon = ht.Count; //dizide kaç değer olduğunu gösterir
			ht.Remove("Car"); //yazılan keyi siler

			//datayı düzenlemek için
			ht["House"] = "Villa"; //house, keyine karşılık olarak ev vardı, villa değeri ile değiştirelim




			ht.Clear();//koleksiyon içindeki tüm datayı siler



		}
	}
}
