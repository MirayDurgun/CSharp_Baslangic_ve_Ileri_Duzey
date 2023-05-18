using System;
using System.Collections;

namespace Stack1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*içerisine almış olduğu dataları bir komut kullanarak sıralı bir şekilde
			 kendi listesinden çıkarmamıza olanak sağlar
			en son girilen data işlem sırasında en önce gelir*/
			Stack S1 = new Stack();

			S1.Push("Bir"); //push bir datayı obje tipinde koleksiyona ekler
			S1.Push("İki");
			S1.Push("Üç");
			S1.Push("Dört");

			object O1 = S1.Pop(); //ilgili datayı bize gönderip listeden çıkarır
			object O2 = S1.Peek(); //ilgili datayı bize gönderir ama listeden çıkarmaz önizleme yapar






		}
	}
}
