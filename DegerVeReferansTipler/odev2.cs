using System;


namespace odev2_Product 
{
    class Program
    {
        //private const string V = " ";

        static void Main(string[] args)
        {
            product product1=new product();
            product1.Id = 1;
            product1.UrunAdi = "Glide FlyEase";
            product1.Model = "Nike";
            product1.Fiyat = 1749;

            product product2 = new product();
            product2.Id = 2;
            product2.UrunAdi = "Air Force 1 Sculpt";
            product2.Model = "Nike";
            product2.Fiyat = 2029;

            product product3 = new product();
            product3.Id = 3;
            product3.UrunAdi = "YZY 700 MNVN";
            product3.Model = "Adidas";
            product3.Fiyat = 3239;

            product product4 = new product();
            product4.Id = 4;
            product4.UrunAdi = "Forum Low";
            product4.Model = "Adidas";
            product4.Fiyat = 1279;

            product[] products = new[] {product1, product2, product3, product4};

            Console.WriteLine("-----------------For Döngüsü------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Detayı" +" "+products[i].UrunAdi+" "+products[i].Model+" "+products[i].Fiyat+"TL");
            }

            Console.WriteLine("-----------------Foreach Döngüsü------------------");

            foreach (var urun    in products)
            {
                Console.WriteLine("Ürün Bilgileri "+ urun.UrunAdi+" "+urun.Model+" "+urun.Fiyat+"TL");
            }
            Console.WriteLine("-----------------While döngüsü------------------");
            int index = 0;
            while (index < products.Length)
            {
                Console.WriteLine(products[index].UrunAdi + "  " + products[index].Model + " " + products[index].Fiyat + "tl");
                index++;
            }
        }
    }
    class product
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string Model { get; set; }
        public int Fiyat { get; set; }

    }




}

