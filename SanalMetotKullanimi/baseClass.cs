using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetotKullanimi
{
	public class baseClass
	{
		//sanal olmayan metot
		public void EkranaYaz(string Data)
		{
			Console.WriteLine(Data); //almış olduğun datayı ekrana yaz
		}
		public baseClass()
		{
			Console.WriteLine("base class");
		}
		public virtual void ekranaYaz(string data)
			//sanal metot yapacağımız zaman 
			//metota ek olarak virtual anahtar kelimesi kullanırız
		{
			Console.WriteLine(data);
		}
	}
}
