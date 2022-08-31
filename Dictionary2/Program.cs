using System;

namespace Dictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> DicList = new Dictionary<int, string>();
            //veri ekliyoruz

            DicList.Add(34, "İstanbul");
            DicList.Add(06, "Ankara");
            DicList.Add(07, "Antalya");
            DicList.Add(16, "Bursa");
            DicList.Add(35, "İzmir");

            Console.WriteLine("Dictionary Listesi");
            foreach (var degeroku in DicList)
            {
                Console.WriteLine(degeroku);
            }
            Console.WriteLine();
            Console.WriteLine("16 : " + DicList[16]);
        }
    }
}
