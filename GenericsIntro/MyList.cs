using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //constructor
        public MyList() // Bunu bir yerde newlersen otomaik çalışır
        {
            items = new T[0]; //array sıfırladın ve o değerini verdin

        }
        public void Add(T item)
           {

            T[] tempArray = items; // refereansı sabit tutsun diye yani altta yenileçeğimiz için tuttuğumuz gecici bellek gibi.
            items=new T[items.Length+1]; //ürün sayısını 1 artırdık  ondan önce newleyip daha sonra arttırıyoruz
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length -1 ] = item; 
        }
    }
}
