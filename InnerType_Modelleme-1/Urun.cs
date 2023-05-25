using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType_Modelleme_1
{
	public class Urun
	{
        //ÖDEV 
        public int urunID { get; set; }
        public string urunAd { get; set; }
        public int urunAdet { get; set; }
        public int urunFiyat { get; set; }

        //Inner Type metotlara erişme ve kullanma tüm classlara yapılacak
        public void UrunTest()
        {
            Console.WriteLine("Ürün test metot");
        }
    }
}
