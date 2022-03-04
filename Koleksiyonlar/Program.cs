using System;
using System.Collections.Generic;


namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //isimler[4] = "ilker";
            //isimler = new string[6];
            //isimler[4] = "kubir";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[5]);
            // Burada ilker kısmını eklemez
            ////isimler[4] = "ilker";   //Array sayısı 4 tane o yüzden ilker yazılamaz bu yüzden diziler genişletilemez
            ////Console.WriteLine(isimler[4]);
            ////Bunun için Koleksiyonlar kullanılır

            List<string> isimler2 = new List<string> { "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);

            isimler2.Add("Engin");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);








        }
    }
}