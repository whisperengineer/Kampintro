using System;

namespace Donguler 
{
    class Program
    {

        static void Main(string[] args)
        {   string ah = 7.13;
            Console.WriteLine(Type(ah));
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Proglamaya başlangıcı yetiştirme kampı";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);   
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            //array-dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "Proglamaya başlangıcı yetiştirme kampı", "Java","Python","C#" };

            for (int i = 0; i < kurslar.Length; i++)//3 yerine kurslar.Length yazarak kurslar içindekilerin hepsinin sayımını yapmış oluruz.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)//foreach dizilere uygulanır in kurslar diziyi dolaş demek kurs orada takma işleme istenilen yazılabilir.
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu-footer");
        }
    }

}

