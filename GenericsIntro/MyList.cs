﻿using System;
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
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
           {

            T[] tempArray = items; // refereansı sabit tutsun diye
            items=new T[items.Length+1]; //ürün sayısını 1 artırdık
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length -1 ] = item; 
        }
    }
}