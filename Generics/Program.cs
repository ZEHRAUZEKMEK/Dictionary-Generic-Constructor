using System;
using System.Collections.Generic;  //1

namespace Generics //koleksiyonlar arka planda array bazlı
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>(); //2
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");

            Console.WriteLine(sehirler.Count); // count tür olarak property
            

            MyList<string> sehirler2 = new MyList<string>(); //4
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T> //3 //Generic class //Type kara verip hepsini barındırıyor. Yukarıyı şekillendirmemize yarıyor.
    {
        T[] _array; //6
        T[] _tempArray;//8 //yedek aldık 
        public MyList() //7
        {
           _array=new T[0];
        }
        public void Add(T item)//5
        {
            _tempArray = _array;//9
            _array = new T[_array.Length + 1];//10
            for (int i=0; i<_tempArray.Length; i++)//11
            {
                _array[i] = _tempArray[i];//12 //newlenmeden önceki elemanların hepsi taşındı.
            }
            _array[_array.Length - 1] = item; //13
        }
   
        public int Count
        {
            get { return _array.Length; }
           
        }

    }
}
