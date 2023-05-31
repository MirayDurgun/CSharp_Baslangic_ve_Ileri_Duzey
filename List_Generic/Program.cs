using System;
using System.Collections;
using System.Collections.Generic;

namespace List_Generic
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ArrayListin Generic versiyonu

			//arraylist
			ArrayList list = new ArrayList();
			list.Add(1);
			list.Add("bir");


			//Generic List
			//<T> : T tipi .net framework içinde olan veya bizim oluşturduğumuz herhangi bir tip demek

			List<int> listeGeneric = new List<int>();
			listeGeneric.Add(1);
			listeGeneric.Add(2);

			for (int i = 0; i < listeGeneric.Count; i++)
			{
				Console.WriteLine(listeGeneric[i]);
			}

			List<string> isimler = new List<string>();
			isimler.Add("miray");
			isimler.Add("Melih");

			for (int i = 0; i < isimler.Count; i++)
			{
				Console.WriteLine(isimler[i]);
			}

			List<musteri> musteriListe = new List<musteri>();
			musteriListe.Add(new musteri()
			{
				ID = 1,
				isim = "Miray",
				soyisim = "Durgun"
			});

			foreach (musteri item in musteriListe)
			{
				Console.WriteLine(item.isim);
			}
		}
	}
}
