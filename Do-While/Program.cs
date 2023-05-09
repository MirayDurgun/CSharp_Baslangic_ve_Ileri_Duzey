using System;

namespace Do_While
{
	internal class Program
	{
		static void Main(string[] args)
		{/*
			while (true)
			{
				//kodların çalıştığı kısım
			}
			*/
			do
			{
                //şart ne olursa olsun 1 kez kesinlikler çalışır 
                Console.WriteLine("Selammm");
            } 
			while (1==2);
			/* 1, 2'ye eşitse birden çok kez selam yazılsın
			 * 1, 2'ye eşit olmadığından while döngüsüne girmeyecek
			 * fakat do while kullandığımızdan 1 kez girecek.
			 * 1 yerine 2 yazsaydık sonsuz kez selam döndürürdü
			 */



		}
	}
}
