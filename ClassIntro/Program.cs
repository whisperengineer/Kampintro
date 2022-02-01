using System;

namespace Donguler
{
    class Program
    {

        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Kubilay";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Kadir";
            kurs3.IzlenmeOranı = 60;

           // Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
           Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3} ;
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +":"+ kurs.Egitmen);

            }




        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}


