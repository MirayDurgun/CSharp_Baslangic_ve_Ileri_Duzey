using System;

namespace AS_Operatoru
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Mantık olarak is ile aynılar
			// is operatöründe bu bumu diye sorup cevabını bool olarak aldık
			//as operatörü tür dönüşümü de sağlar

			string ben = "Miray Durgun";
			object objectstring = ben;
			//objectstringde bendeki değeri değişkenle atar yani kutulama yapar
			string sonuc = objectstring as string;
			//objectstring içindeki değer eğer string ise
			//oradaki değeri string olarak farklı bir string değerinin üzerine al sonuc
			//as te hata alma olasılığı yüksek genelde is kullanılır
		}
	}
}
