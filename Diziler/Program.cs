using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler;
            isimler = new string[4];
            isimler[0] = "Ali";
            isimler[1] = "Mehmet";
            isimler[2] = "Ahmet";
            isimler[3] = "Ayşe";

            int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var eleman in rakamlar)
            {
                Console.WriteLine(eleman);
            }

            //rakamlar arrayinden 8. indexten itibaren 2 adet sil dedik
            Array.Clear(rakamlar, 8, 2);
            for (int i = 0; i < rakamlar.Length; i++)
            {
                Console.WriteLine(rakamlar[i]);
                //rakamları sildikten sonra default olan 0 değerini basar ekrana
            }

            //alfabetik olarak sıralamamıza yarıyor
            Array.Sort(isimler);
            //ters çevirme
            Array.Reverse(isimler);
            foreach (var eleman2 in isimler)
            {
                Console.WriteLine(eleman2);
            }

            //int döner bize. hangi elamanın hangi indexe sahip olduğunu bulmamıza yarar
            //aradığımız key yoksa -1 döner
            //yukarıdaki gibi sort veya reverse gibi çevirme işlemi yaparsak index değişir
            //aynı isimden birden fazla varsa ilk bulduğunu verir

            int indeks = Array.IndexOf(isimler, "Mehmet");
            Console.WriteLine("Listenin {0}. indeksindedir.", indeks);

            //varsa indeks verir yoksa -1 verir sondakini verir her zaman
            int sonSira = Array.LastIndexOf(rakamlar, 0);
            Console.WriteLine(sonSira);

            Console.ReadLine();
        }
    }
}
