using System;

namespace Abstract_Nedir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//TemelSinif T1=new TemelSinif(); abstract olduğu için örneklenmez

			Musteri M1 = new Musteri(); //temel sinifi miras aldığı için m1 üzerinden temel sinif clasındaki içeriklere ulaşabiliriz
										//M1.kayitTarih

			M1.Test();
			M1.TestAbstract();


			SuperMusteri SM1 = new SuperMusteri();
			SM1.TestAbstract();


		}
	}
}
