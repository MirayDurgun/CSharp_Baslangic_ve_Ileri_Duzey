using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_Odev
{
	public static class SanalDatabase
	{
		//barkod
		private static ArrayList db = new ArrayList();
		//dışarıdan erişilsin ama set edilmesin bu nedenle private yaptık
		//örneklemek için statşc yapıcı metotta kullanılabilirdi 
		//ya da kısayoldan = new mantığı

		public static void yeniUrunEkle(Base_Class data) //base classtan türeyenleri kapsar
		{
			//arrayList içinde eklemek istediğimiz barkod bulunuyorsa ekleme
			if (data != null && !string.IsNullOrEmpty(data.barkod))
			{
				//data ve barkod alanı boş değilse içeriye datayı ekle
				db.Add(data); //ürün ekleme

			}

		}
		public static bool dbBarkodKontrol(string barkod)
		{
			bool kontrolIslemi = false;
			if (db != null && db.Count > 0)  //db boş değilse ve count 0dan büyükse for döngüsüne girsin
			{
				for (int i = 0; i < db.Count; i++) //db count kadar dönsün
				{
					Base_Class bc = (Base_Class)db[i]; //objedeki değeri base classa çeviriyoruz
					if (bc.barkod == barkod) //baseclasstaki barkod parametre olarak gelen barkoda eşit ise
						kontrolIslemi = true; //true dönsün
				}
			}
			return kontrolIslemi; //girmezse false dönsün
		}
	}
}
