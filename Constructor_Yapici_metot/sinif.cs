using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Yapici_metot
{
	public class sinif
	{
        /*yapıcı metotta nesneleri örneklerken içinde bulunan fieldlerin
		 bir değer alması gerek, yapıcı metotlara müdahele etmezsek arka tarafta oluşur ve boş bir şekilde durur
		*/

        public string tc, ad, soyad;
        public int cinsiyet;
        public sinif()
        {
            tc = "42000000000"; //default olarak gelen tc nosu null idi
            //default değerini vermiş olduk
        }
        public sinif(string tcKimlikNo)
        {
            tc = tcKimlikNo;
            
        }
        public sinif(string tcKimlikNo,string isim)
        {
            tc= tcKimlikNo;
            ad=isim;
            
        }
        public sinif(string tcKimlikNo,string isim, string soyisim)
        {
            tc = tcKimlikNo;
            ad=isim;
            soyad=soyisim;
        }
        public bool MusteriKontrol()
        {
            //database gider müşterinin tcsine göre 
            //daha önce kayıt edilip edilmediğini kontrol eder
            return true;
        }
        private bool MusteriKontrolDatabase(string tckimlikno)
        {
            return true;
        }
    }
}
