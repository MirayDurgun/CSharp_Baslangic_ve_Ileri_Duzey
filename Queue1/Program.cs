using System;
using System.Collections;

namespace Queue1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* ilk girilen data işlem sırasında en önde gelir
			 yani ilk giren ilk çıkar
			*/

			Queue Q1 = new Queue();
			Q1.Enqueue("Bir"); //ekler
			Q1.Enqueue("İki");
			Q1.Enqueue("Üç");
			Q1.Enqueue("Dört");

			object O1 = Q1.Peek();
			object O2 = Q1.Dequeue();


		}
	}
}
