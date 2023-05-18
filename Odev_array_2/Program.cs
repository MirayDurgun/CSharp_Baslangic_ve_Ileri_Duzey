using System;
using System.Collections;

namespace Odev_array_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Ekran ilk açıldığında kullanıcının karşına bir menü gelsin
			 1. değer ekle
			2. değer listele
			3.değer ara
			4. düzenle
			5. sil
			yapıyı switch ile kur
			*/

			string kullaniciSecim, kullaniciDeger;
			ArrayList degerListesi = new ArrayList();
			do
			{
				Console.Clear();
				Console.WriteLine("Menü");
				Console.WriteLine("1 - Değer ekle");
				Console.WriteLine("2 - Değer listele");
				Console.WriteLine("3 - Değer ara");
				Console.WriteLine("4 - Değer düzenle");
				Console.WriteLine("5 - Değer sil");
				Console.WriteLine("6 - Uygulama çıkış");
				Console.WriteLine("Seçiniz :");
				kullaniciSecim = Convert.ToString(Console.ReadLine());

				switch (kullaniciSecim)
				{
					case "1":
						Console.WriteLine("Eklemek istediğiniz değeri giriniz");
						kullaniciDeger = Console.ReadLine();
						degerListesi.Add(kullaniciDeger);
						Console.WriteLine("Değeriniz listeye eklendi");
						System.Threading.Thread.Sleep(1000);//uygulamanın belirtmiş olduğumuz saniye kadar işlemleri bekletir
						break;
					case "2":
						for (int i = 0; i < degerListesi.Count; i++)//kapasitesi kadar dönemez bu nedenle count kullandık
						{
							Console.WriteLine("{0}. index, değer = {1}", i, degerListesi[i]);
						}
						Console.WriteLine("Değerler listelendi");
						Console.WriteLine("Devam etmek için bir tuşa basınız");
						Console.ReadLine();
						break;
					case "3":
						Console.WriteLine("Lütfen aratmak istediğiniz değeri giriniz");
						kullaniciDeger = Console.ReadLine();
						bool ara = degerListesi.Contains(kullaniciDeger);
						Console.WriteLine("Değeriniz arandı");
						if (ara)
						{
							int arananIndex = degerListesi.IndexOf(kullaniciDeger);
							string bulunanDeger = degerListesi[arananIndex].ToString(); //bulunan indexin değerini
																						//stringe çevirir
							Console.WriteLine("{0} girdiğiniz değer bulundu ve index =miyim {1}", kullaniciDeger, arananIndex);
						}
						else
						{
							Console.WriteLine("Aradığınız değer bulunamadı");
							//ödev
							//aradığı değeri bulamadıysa kullanıcıya bu değeri listeye ekleyelim mi diye sorsun
							//kullanıcı e derse eklesin h derse eklemesin 
							Console.WriteLine("Bu değeri listeye ekleyelim mi? \n Lütfen evet ise 'E' hayır ise 'H' seçiniz");
							string karar = Console.ReadLine();
							if (karar == "E" || karar == "e")
							{
								degerListesi.Add(kullaniciDeger);
								Console.WriteLine("Değeriniz listeye eklendi");

							}
							else
							{
								Console.WriteLine("Hayır yanıtını seçtiniz, kullanıcı eklenmedi");
							}
						}
						System.Threading.Thread.Sleep(2000);
						break;

					case "4":
						Console.WriteLine("Güncellemek istediğiniz değeri giriniz");
						kullaniciDeger = Console.ReadLine();
						Console.WriteLine("{0} değerini hangi değer ile güncellemek istersiniz?", kullaniciDeger);
						string kullaniciDeger2 = Console.ReadLine();
						if (degerListesi.Contains(kullaniciDeger)) //kullanıcının girdiği değer listede var mı diye kontrol eder
						{
							int arananIndex = degerListesi.IndexOf(kullaniciDeger);
							degerListesi[arananIndex] = kullaniciDeger2;//Değer listesinin indexini buldu
																		//kullanıcının değiştirmek istediği değeri indexe ata
							Console.WriteLine("Değeriniz güncellendi");
						}
						else
						{
							Console.WriteLine("Aradığınız değer bulunamadı");
						}
						System.Threading.Thread.Sleep(1000);
						break;
					case "5":
						Console.WriteLine("Tüm değer silisin mi?\n Evet ise 'E' Hayır ise 'H' seçiniz");
						string kullaniciTercih = Console.ReadLine();
						if (kullaniciTercih.ToUpper() == "E")
						{
							degerListesi.Clear();
                            Console.WriteLine("Tüm değerler silindi");
                        }
						else
						{
							Console.WriteLine("Silmek istediğiniz değeri yazınız");
							kullaniciDeger = Console.ReadLine();
							if (degerListesi.Contains(kullaniciDeger))
							{
								degerListesi.Remove(kullaniciDeger);
								Console.WriteLine("Değer listeden silindi");

							}
							else
							{
                                Console.WriteLine("Silinecek değer bulunamadı");
                            }
						}

						break;
					default:
						break;
				}
			}
			while (kullaniciSecim != "6");

		}
	}
}
