using System;

namespace Generic_Koleksiyonlar
{
	internal class Program
	{
		static void Main(string[] args)
		{

			/*Generic koleksiyonlar, bir programlama dilindeki veri yapılarının 
			 * farklı veri tipleriyle çalışabilmesini sağlayan bir özelliktir. 
			 * Bu özellik, bir koleksiyon içindeki öğelerin türünün 
			 * belirli bir veri türüne bağlı olmasına izin verir
			 * ve böylece aynı koleksiyonu farklı veri tipleriyle kullanabilirsiniz.
			Generic koleksiyonlar, tip güvenliğini artırır ve kodun daha esnek 
			ve yeniden kullanılabilir olmasını sağlar. 
			Koleksiyonlar, liste, dizi, yığın, kuyruk vb. gibi veri yapılarını temsil edebilir.
			Örneğin, C# programlama dilinde List<T> sınıfı bir generic koleksiyon örneğidir. 
			"T" parametresi, koleksiyonun hangi veri türüyle çalışacağını belirtir. 
			Böylece, List<int>*/

			sanalDatabase sDatabase = new sanalDatabase();
			sDatabase.yeniKayit(1);



		}
	}
}
