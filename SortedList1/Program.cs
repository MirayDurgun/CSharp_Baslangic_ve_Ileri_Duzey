using System;
using System.Collections;

namespace SortedList1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*hashtable ile farkı
			 hashtable gibi içine key ve value değerleri alır
			farkı ise içine aldığı her değerin key değerine göre sıralar
			küçükten büyüğe doğru*/
			SortedList sortedL = new SortedList();
			sortedL.Add(100, "yüz");
			sortedL.Add(90, "doksan");
			sortedL.Add(80, "seksen");
			sortedL.Add(1, "bir");
			sortedL.Add(1000, "bin");
		//	sortedL.Add("a", "b"); hata verir key değeri int olmalı

		}
	}
}
