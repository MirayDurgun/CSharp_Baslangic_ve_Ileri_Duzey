
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Kalitim_NesneModelleme;

namespace Kalitim_NesneModelleme
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Yorum satırı başlangıç

			TemelTip T1 = new TemelTip();
			T1.TemelTipMetot1();
			//TemellTip classındaki metoda erişim sağladık

			Egitmen E1 = new Egitmen();
			Console.WriteLine("Eğitmen nesnesi örneklendi.");
			E1.TemelTipMetot1();
			//Temeltip classındaki metoda eğiştmen üzerinden de erişim sağlayabiliyoruz


			//özel tiplerde boxing ve unbaxing işlemi
			// Bizim object nesnemiz nedir ? 
			//yani en temel nesnemiz nedir = temeltip
			TemelTip T2; //objemizi oluşturduk

			// Hangi nesnelerde temeltip object görevi görür?
			// Personel Egitmen ve Ogrenci 
			// Temeltip nesnesinden türedikleri için temel tip nesnesi bu nesnelerde object gibi davranır. 
			//Temeltipi miras aldıkları için

			T2 = E1; // Egitmen nesnesini Temeltip nesnesine atadık -boxing
			E1 = (Egitmen)T2; // Unboxing 


			Personel P1 = new Personel();
			T2 = P1; // Personel nesnesini Temeltip nesnesine atadık -boxing
			P1 = (Personel)T2; // Unboxing 


			Ogrenci O1 = new Ogrenci();
			T2 = O1; // Ogrenci nesnesini Temeltip nesnesine atadık -boxing
			O1 = (Ogrenci)T2; // Unboxing 


			object O3 = T2;


			// Boxing -- Unboxing 

			object Ob1 = E1;     // Boxing -kutulama 
			E1 = (Egitmen)Ob1;   // Unboxing tekrardan eski haline çevirme


			//******************************************************************************************


			Personel Per1 = new Personel();
			Per1.TemelTipMetot1();

			Ogrenci Ogr1 = new Ogrenci();
			Ogr1.TemelTipMetot1();


			object Obj1 = Ogr1; //boxing
			Ogr1 = (Ogrenci)Obj1;  //unboxing

			Obj1 = Per1;  //boxing
			Per1 = (Personel)Obj1;  //unboxing



			#endregion

			/*türemiş olan tiplerim türeyemesin... 
			 objeden temel tip, temel tipten personel türedi
			object => temeltip => Personel =>  personel türesin
			object => temeltip => Ogrenci  => X öğrenci türeyemesin
			object => temeltip => Eğitmen  => X eğitmen türeyemesin*/


			Test T10 = new Test(); //Test clası egitmeni miras aldı
								   //T1 çağırınca hem eğitmen içindeki hemde eğitmenin miras aldığı temel tip içindeki verilere erişebiliriz

			// Hangi nesnemizin kalıtılmasını (türetilmesini) istemiyoruz ? 
			//Egitmen nesnesi kalıtılmasın
			//bu durumda eğitmen nesnesi sealed olarak işaretlenmeli

			//SEALED anahtar kelimesi nesneye verildiğinde  kalıtımı engelleiyor
			//verildiği nesne kalıtılamıyor yani başka sınıf tarafından miras alınamıyor



			//eğitmen claası personeli miras aldı bu sayede hem personelin hemde temel tipin verilerine erişir
			//personel ise yalnızca temeltipin verilerine erişir
			Egitmen E10 = new Egitmen();

			//gidişi ve dönüşü
			//Egitmen => Personel => TemelTip => Object
			//Object => TemelTip => Personel => Egitmen

			// public : uygulamamızın içerisinde veya dışarısında ulaşılabilir anlamını taşır. 
			// private : sadeece tanımlandığı class içerisine erişilebilir olur. 
			// protected : Normal kullanımda (kendi içinde) private olarak davranır. kalıtım yolu ile
			//başka bir class içerisinde public olarak kullanılır. 

			TemelTip Ttip1 = new TemelTip();

			Ogrenci Ogrenci10 = new Ogrenci();
			Ogrenci10.TemelTipMetot1();
			//Ogrenci clasında TemelTipMetot2ye erişim sağlayabiliyoruz (protected metoda) kalıtıldığı için
			//fakat oorgenci nesnesi üzerinden TemelTipMetot2 ye erişim sağlayamayız çünkü erişim belirleyecisi protected

		}
	}
}
