using Metotlar;
using System;


namespace Kampintro
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya e lması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyerbakır karpuz1";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe --tip güvenli
            foreach (Urun urun in urunler)

            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("--------------mETOTLAR ");
            //instance-örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,5);
            sepetManager.Ekle2("Elma", "Yeşil elma", 1,9);
            sepetManager.Ekle2("Karpuz", "Diyerbakır karpuz", 13, 8);
            

        }
    }

}

// Dont repeat yourself