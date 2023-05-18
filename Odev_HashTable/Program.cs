using System;
using System.Collections;
using System.Data;
using System.Xml.Schema;
using Microsoft.VisualBasic;

namespace Odev_HashTable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Hashtable içerisine ENG - TR olarak data eklemeniz
			 yeni kayıt eklemek istiyor musun e/h 
			e= kayıt ekle
			h= tüm listeyi yazdır
			var olan değer eklemek isteniyorsa  bu değer bulunmakta desin*/
			Hashtable Sozluk = new Hashtable();

			Console.WriteLine("Yeni kayıt eklemek istiyor musunuz");
			do
			{
				Console.Clear();
				Console.WriteLine("Eklemek istediğiniz sözlük değerini giriniz");
				Console.Write("EN : ");
				string ENG = Console.ReadLine();

				bool kontrol = Sozluk.ContainsKey(ENG);
				//key varsa bool yazmak gerek
				if (kontrol)
				{
					Console.WriteLine("Eklemek istediğiniz değer {0} sözlük içerisinde bulunmaktadır. {1} değerin türkçe karşılığıdır", ENG, Sozluk[ENG].ToString());
					//Sozluk[ENG] sözlük veri tabanının keyinden obje olarak döndürür 
				}
				else
				{
					Console.WriteLine("{0} ingilizce değerin türkçe karşılığını yazınız", ENG);
					string tr = Console.ReadLine();
					Sozluk.Add(ENG, tr);
					Console.WriteLine("Değer ekleme işlemi başarılı");
				}
				Console.WriteLine("Yeni değer eklemek istiyor musunuz? \n Evet / Hayır");
			}
			while (Console.ReadLine().ToUpper() != "H"); //kullanıcıdan gelen değer H ye eşit değilse girilen değeri büyüt
														 //hayıra eşit değilse if'in içine tekrar girer

			//1. yöntem ilgili hashtablenin keyleri içinde döner
			foreach (var item in Sozluk.Keys)
			{
				Console.WriteLine("ENG : {0} = TR : {1}", item, Sozluk[item]);//sözlük veri tabanının keylerinde döner
																			  //item keyi temsil etmekte, Sozluk[item] diğer karşılığı 
			}
			/*//2. yöntem
			foreach (DictionaryEntry item in Sozluk)
			{
				//sözlük veri tabanı içindeki her bir item'ın ne olduğunu bilmediğimizden var yerine
				//DictionaryEntry sayesinde datanın karşılığını alırız
				Console.WriteLine("ENG : {0} = TR : {1}", item.Key, item.Value);
			}
			//2. yöntemi var ile yapma
			foreach (var item in Sozluk)
			{
				//tipini öğrenmek için;
				Console.WriteLine(item.GetType().Name);

			}
			*/






		}
	}
}
