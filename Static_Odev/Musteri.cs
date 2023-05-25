using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Static_Odev
{
	public class Musteri
	{
		#region Sanal Database
		static ArrayList musteridatabase;


		#endregion

		#region Static Yapısı Metot
		static Musteri()
		{
			musteridatabase = new ArrayList(); //musteri database örnekledik
											   //musteri clasını çağırdığımızda artık database de gelecek
		}

		#endregion

		#region Field
		public int musteriID { get; set; }
		public string isim { get; set; }
		public string soyisim { get; set; }
		public string emailadres { get; set; }
		public string _kullaniciad { get; set; }
		public string sifre { get; set; }

		#endregion

		#region Kapsülleme
		public string KullaniciAd
		{
			get { return this._kullaniciad; }
			set
			{
				bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);
				if (kullaniciAdiKontrol)
				{
					Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlı");
					this._kullaniciad = string.Empty;
				}
				else
				{
					this._kullaniciad = value;
				}
			}
		}

		#endregion

		#region Static Metot
		static bool musteriKullaniciAdiKontrol(string _kullaniciAdi)
		{
			bool Kontrol = false; //default olarak false gelir
			for (int i = 0; i < musteridatabase.Count;)
			//müşteridarabase bir array list buda kendisine gelen bütün tipleri objeye çevirip saklar

			{
				Musteri Temp = (Musteri)musteridatabase[i];
				//müşteri kullanıcı adı datada var mı kontrol ederiz
				//bunun için musteridatabase[i] üzerinden ulaşırız ve obje olarak saklar
				//fakat gelen değeri obje olarak kullanamayız çünkü fieldlere erişim sağlamamız gerek
				//(Musteri) objeden geri çevirmek içinde müşteri tipini kullanılırız.
				if (Temp.KullaniciAd == _kullaniciAdi)
				{
					Kontrol = true;
					break;
				}

			}
			return Kontrol;
		}

		public static void MusteriEkler(Musteri M)
		{
			#region Parametre Kontrol
			if (M != null && !string.IsNullOrEmpty(M.KullaniciAd) && !string.IsNullOrEmpty(M.emailadres)) //parametreden gelen değer null değilse ve
																										  //kullanıcı adı null ya da boş değilse
																										  // ve email adres boş ya da null değilse işlemleri döndür
			{
				bool emailAdresKontrol = musteriEmailKontrol(M.emailadres);
				if (emailAdresKontrol)
				{
					Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı");
				}
				else
				{
					musteridatabase.Add(M); //parametre olarak gelen nesnemi arraylist içine ekle
					Console.WriteLine("Yeni kayıt işlemi başarılı");
				}
			}
			#endregion
		}
		//kullanıcının email adresine göre kontorl sağlamak
		static bool musteriEmailKontrol(string _email)
		{
			bool Kontrol = false;
			for (int i = 0; i < musteridatabase.Count;) //musteri database kaç tane ise o kadar dön
			{
				Musteri Temp = (Musteri)musteridatabase[i];
				if (Temp.emailadres == _email)
				{
					Kontrol = true;
					break;
				}
			}
			return Kontrol;
		}
		#endregion
	}
}
