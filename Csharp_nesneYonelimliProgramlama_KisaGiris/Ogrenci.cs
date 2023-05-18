using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_nesneYonelimliProgramlama_KisaGiris
{
	public class Ogrenci
	//public erişim belirleycisi kullanıyoruz classlarımıza her yerden erişebilmek için
	{
		//metot geriye bir şey döndürecek mi?
		//yani kendisini çağıran noktaya bir değer ataması yapacak mı?
		//yapmayacaksa void kullanıyoruz yapacaksa return
		//kısaca metotlarımız bir değer ataması yapmayacaksa void kullanıyoruz
		public void SelamlaOgrenci()
		{
			Console.WriteLine("Selam Öğrenci");
		}
		/*[Erişim Belirleyicisi] <geri dönüş değeri> Metot Adı (parametreler)
		 * {
		 * metot için gereken kodlar
		 * }
		 * 
		 * 
		 * erişim belirleyicisi
		 *  farklı erişim belirleyicisi bulunur
		 *  
		 *  public = hiçbir kısıtlaması yoktur. her yerden erişime olanak tanır
		 *  private = sadece bulunduğu class içinden erişilir
		 *  protected = bulunduğu class içinden erişilen ve bulunduğu classı miras alan classlar içinden erişilir
		 *  Internal = bulunduğu proje içerisinde her yerde erişilebilir
		 *  Internal Protected
		 */
		public void OgrenciMetot(string ogrenciAdi, string ogrenciSoyadi)
		{
			Console.WriteLine("Öğrenci bilgileri : {0} {1}", ogrenciAdi, ogrenciSoyadi);
		}
		private void OgrenciMetot2(string ogrenciAdi, string ogrenciSoyadi)
		{
			Console.WriteLine("Öğrenci bilgileri : {0} {1}", ogrenciAdi, ogrenciSoyadi);
		}
	}
}
