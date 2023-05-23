using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Nedir
{
	public class Ogrenci
	{
		public string isim;
		public string soyisim { get; set; } //2 türlü de yazılabilir
		public string Email { get; set; }
		public void Test1()
		{
			Console.WriteLine("Nesne örneği alındıktan sonra çalışan metot");
			Test2();
			//static metotlar, static olmayan metotların içersinden de çağırılabilir
		}
		public static void Test2()
		{
			Console.WriteLine("Nesne örneği alınmadan çalışan metot");
			//test1 static metot, static olmayan bir metot çağıramaz 
		}
	}
}
