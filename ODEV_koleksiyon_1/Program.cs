using System;
using System.Collections;

namespace ODEV_koleksiyon_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//10 elemanlı string olarak ArrayList
			//içindeki değerleri Z-A sıralayınız

			 
			ArrayList B1 = new ArrayList();
			B1.Add("Merve");
			B1.Add("Melis");
			B1.Add("Melih");
			B1.Add("Can");
			B1.Add("Canan");
			B1.Add("Umut");
			B1.Add("Gül");
			B1.Add("Hilal");
			B1.Add("Eylül");
			B1.Add("Ekim");

			B1.Sort();
			B1.Reverse();
			//debug atarak bak


        }
	}
}
