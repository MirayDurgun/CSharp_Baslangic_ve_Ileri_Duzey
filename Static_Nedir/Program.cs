using System;

namespace Static_Nedir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*static nedir
			 nesne öreneği alınmadan ulaşabildiğimiz metot, field, sınıf olabilir
			staticte =new kavramı unutulur, kullanılmaz

			 örneklerken 
			metot m1=new metot(); olarak kullanılırdı
			staticte  metot. yetmekte*/


			Ogrenci O1;
			//stack bölgede pointer oluştu
			//pointer oluştuğu zaman static olan yapısı metot çalıştı ve yine class içinde 
			//tanımlı olan field, metot dediğimiz bözlege oluşturuldu
			O1 = new Ogrenci();
			//nesne örneği almak istediğimizde stack bölgede oluşan pointer 
			//kendisini heap bölgede tamamladı
			//yani static olmayan tanımlarını tamamladı

			O1.Test1(); //nesne örneği alındıktan sonra test1 metoduna ulaştık

			Ogrenci.Test2(); //örneklemeden çağırmış oluruz

			/*Static kavramı gerçek hayatta nerelerde kullanılır?
			 1- Genel olarak kullanıldığı yerler nesne örneğinin alınmasını istemediğimiz yerlerde kullanılır
			2- oluşturduğumuz nesnemizin bağımlılığı farklı classlara olduğu için nesne içerisinde static metot tanımları yapılır
			3- class içerisinde bir field (static) tanımı yapar ilgili field içerisine bir değer ataması yaparız
			daha sonra uygulama içerisine N farklı yerde oluşturmuş olduğumuz static fielde ulaşır değeri okuruz
			4- [uygulama] => [ozelhelper] => [DDL] 
			*/

		}
	}
}
