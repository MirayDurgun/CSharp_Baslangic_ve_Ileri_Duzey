using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_Odev
{
	public class Base_Class
	{
		public static int sayac = 1;  //idyi takip eden sayac
									  //ilk oluştuğunda 1 değerini alsın

		public Base_Class()
		{
			//id işlemleri
			this._id = sayac;
			sayac = sayac + 1;

		}

		private int _id;
		public int id
		{
			get { return _id; }
			private set
			{
				//bir sayaç içindeki değerden faydalanacağız
				//idyi takip ettirip bir sonraki değeri alacağız
				//ve dışarıdan id değeri giremesin bunun için set kısmını private yapıyoruz

				///this._id = sayac; //sayaçtaki 1 değerini idye atadık
				//sayac = sayac + 1; //static taraftaki bulunan değeri arttırdık
				//id gelmedi çünkü set alanı private  gelmesi için yapıcı metot oluşturmalıyız
			}
		} //kontrolü olacak


		private string _barkod;
		public string barkod
		{//kontrolü olacak
			get { return _barkod; }
			set
			{
				bool KontrolIslemi = SanalDatabase.dbBarkodKontrol(value);
				if (!KontrolIslemi) //değeri sanal database içinde bulamadıysa yanı kontrol false ise
				{
					_barkod = value;
				}
				else
				{
					Console.WriteLine("Sanal database içinde bu barkod değeri daha önce girilimiştir");
				}
				//sanal databasede bu barkod alanı varsa uyarı çıksın yoksa barkod kabul edilsin
				//bu işlemi sette değil metotla yapacağız
				//sanal database classı içinde olacak/

			}
		}

		public DateTime olusturnaTarih { get; set; }
		public int olusturanKullanici { get; set; }

		public DateTime guncellemeTarih { get; set; }
		public int guncelleyenKullanici { get; set; }

		public bool silindi { get; set; }
	}
}
