using System;

namespace Kampintro
{
    class  Program
    {

        static void Main(string[] args)
        {




            // type safety-tip güvenliği
            // Do not repeat yourself -Kendini tekrarlama


            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool  sistemeGirisYapmismi=true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");

            }

            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmismi== true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);


             

                
        }
    }

}
