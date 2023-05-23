using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Field_Kullanim
{
	public static class Helper_2
	{
		// Static class kullanımı

		public static void emailGonder(string aliciEmail, string konu, string icerik)
		{
			Console.WriteLine("Mail Gönderildi");
		}
		/* public void Test() //static class içinde normal metotlar kullanılamaz
         {
             Console.WriteLine("test");
         }*/

		/*public Helper_2()
        {
                her nesne örneği alındığında uygulama standart yapıcı metot çalıştırır
        }*/
		static Helper_2()
		{
			//static yapıcı metotlar uygulama boyunca bir kez çalışır o da ilk çağırıldığında
			Console.WriteLine("Static yapıcı metotlar yalnızca 1 kez çalışırlar");
		}
	}
}
