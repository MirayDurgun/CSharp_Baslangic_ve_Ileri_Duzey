using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verileri_Kapsulleme_1
{
	internal class Musteri
	//internal: oluşturulduğu katmanda sadece çağırılabilir
	{
		//Class => Field
		public int id;
		public string name;
		public string surname;

		//ornek 1 fielde her yerden erişmemem gerek 
		private string emailAdres;
		//her yerden erişilebilir olaacak yani public ve aldığı değeri içeriden private a gönderecek
		//buna uyguun property tanımlanır

		public string EmailAdres
		{
			get; //database veya farklı bir veri kaynağından datayı çekeriz.
				 //Get değeri karşıya gösterir 
			set; //Datayı çekip değer atamasını yapar
				 //private olarak saklanan field içine değer atar
		}
	}
}
