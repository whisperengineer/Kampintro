using System;
using System.Collections.Generic;
using System.Text;


namespace Metotlar
{    
    //naming convention
    //syntx
    class SepetManager
    {   //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("tebrikler.sepete eklendi:" + urun.Adi);
        }
         
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler,Sepete eklendi:"+ urunAdi);
        }
    }
}
