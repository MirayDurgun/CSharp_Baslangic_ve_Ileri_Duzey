using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verileri_Kapsulleme_Odev_1
{
	//Ornek 2 Field Değer ataması yapılsın ama değer okunamasın
	//seti private yapmak
	//Ornek 3 Field Değer ataması yapılsın ama ilk 3 hanesi okunsun

	/*tc değeri oluştur
	 11 haneli olsun
	sayısal değer girilmek zorunda
	değeri okunamaz şekilde ayarla
	ilk 3 hanesini görelim
	son seçenek
	field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde  bizim belirlediğimiz
	bir süreçten geçsin veri daha sonra gösterilsin*/
	internal class Musteri
	{
		public int id;
		private string _tckimlikno;
		public string ad;
		public string soyad;


		public string TcKimlikNo
		{
			get //3 hanesini gösterelim
			{
				return _tckimlikno.Substring(0, 3); //substring ile 0 başla 3 karakter al diyerek ilk 3 haneyi gösteririz
			}
			set
			{
				if (value.Length == 11) //değerin uzunluğuysa 11'e
				{
					bool kontrol = false;
					for (int i = 0; i < value.Length; i++) //içerisindeki değerler sayısal değer olmalı
					{
						bool KarakterKontrol = char.IsNumber(value[i]); //verilmil olan değerin number olup olmadığını kontrol eder
						if (KarakterKontrol)
						{
							//true ise sayısal değerdir
						}
						else
						{
							//false yani içerde istenmedik değer yakaladık
							kontrol = true;
							break;
						}
					}
					if (kontrol)
					{
						//istemediğimiz değeri yakaladıysak değeri alma
						Console.WriteLine("Tc kimlik numarası içindeki değerler sayısal olmalıdır");
					}
					else
					{
						//yakalanmadıysa 
						this._tckimlikno = value; //değeri içe at
					}
				}
				else
				{
					Console.WriteLine("TC 11 haneli olmalıdır");
				}

			}
		}
	}
}
