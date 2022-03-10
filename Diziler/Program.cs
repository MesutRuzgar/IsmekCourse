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
            //ArraysIntro();
            //Example();

            //CokBoyutluDize();

            Console.ReadLine();
        }

        private static void CokBoyutluDize()
        {
            //çok boyutlu dize oluşturmak için

            string[,] sehirler = new string[4, 2] { { "İstanbul", "Türkiye" }, { "Nice", "Fransa" }, { "Milano", "İtalya" }, { "Prag", "Çekya" } };
            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }
        }

        private static void Example()
        {
            int[] sinavlar = new int[5];
            Console.WriteLine("Lütfen 5 adet sınav notunuzu giriniz");
            for (int i = 0; i < 5; i++)
            {
                sinavlar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("Değiştirmek istediğiniz not varsa 1'e basınız\nSilmek istediğiniz not varsa 2'ye basınız\nNotlarınızı yüksekten düşüğe sıralamak için 3'e basınız");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Hangi notunuzu güncellemek istiyorsunuz?");
                    int not = int.Parse(Console.ReadLine());
                    int notunIndexi = Array.IndexOf(sinavlar, not);
                    if (notunIndexi != -1)
                    {
                        Console.WriteLine("Güncel notunuzu yazınız");
                        int yeniNot = int.Parse(Console.ReadLine());
                        sinavlar[notunIndexi] = yeniNot;
                        Console.WriteLine("Notunuz güncellendi.");
                        foreach (var item in sinavlar)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir not girilmedi");
                    }
                    break;

                case 2:
                    Console.WriteLine("Hangi notunuzu silmek istiyorsunuz?");
                    int silinecekNot = int.Parse(Console.ReadLine());
                    int silinecekNotunIndexi = Array.IndexOf(sinavlar, silinecekNot);
                    if (silinecekNotunIndexi != -1)
                    {
                        Array.Clear(sinavlar, silinecekNotunIndexi, 1);
                        Console.WriteLine("Notunuz Silindi");
                        foreach (var item in sinavlar)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir not girilmedi");
                    }
                    break;

                case 3:
                    Array.Sort(sinavlar);
                    Array.Reverse(sinavlar);
                    foreach (var item in sinavlar)
                    {
                        Console.WriteLine(item);
                    }

                    break;


                default:
                    Console.WriteLine("Yanlış seçim yaptınız");
                    break;
            }
        }

        private static void ArraysIntro()
        {
            string[] isimler = new string[4];
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
        }
    }
}
