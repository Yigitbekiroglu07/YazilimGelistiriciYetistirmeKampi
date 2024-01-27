using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
     class MyList<T>
    {
        T[] items;
        // Constructor >> class'ı newlediğimizde otomatik çalışır.
        public MyList()
        {
            items = new T[0];   
        }
        public void Add(T item) 
        {   
        T[] tempArray = items; // Geçici dizinin referansı = items'in referansı. Bunu yapma sebebimiz önceki referans numarasının kaybolmamasını sağlamak.
        items = new T[items.Length + 1]; // T[items.Length] dizinin eleman sayısını verir.  
        for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  // Dizinin önceki elemanlarını tutmak için.      
            }
            items[items.Length-1] = item; //items'den gelen son elemanı eklemek için.
        } 


    }
}
