using System;
using System.Collections.Generic;

namespace Dictionary3
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> agaclar = new List<string>();

            agaclar.Add("Çam");
            agaclar.Add("Ihlamur");
            agaclar.Add("Ladin");
            agaclar.Add("Söğüt");
            agaclar.Add("Akasya");

            Console.WriteLine(agaclar.Count);

            MyList<string> agaclar2 = new MyList<string>();

            agaclar2.Add("Çam");
            agaclar2.Add("Ihlamur");
            agaclar2.Add("Ladin");
            agaclar2.Add("Söğüt");
            agaclar2.Add("Akasya");
            agaclar2.Add("Ardıç");
            Console.WriteLine(agaclar2.Count);

        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        private int _count;

        public int Count
        {
            get { return _array.Length; }

        }

    }
}
