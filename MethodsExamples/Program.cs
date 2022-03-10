using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1();
            int secim;
            do
            {
                Console.WriteLine("Kuraya kaç kişi katılacak?");
                int kisiSayisi = int.Parse(Console.ReadLine());
                string[] kisiListesi = new string[kisiSayisi];
                for (int i = 0; i < kisiListesi.Length; i++)
                {
                    Console.WriteLine("Kuraya katılacak ismi giriniz.");
                    kisiListesi[i] = Console.ReadLine();
                }
                int kuraSiralamasi = new Random().Next(0, kisiSayisi - 1);
                Console.WriteLine("Kazanan:{0}", kisiListesi[kuraSiralamasi]);
                Console.WriteLine("Yeni bir kura başlatmak için 1'i tuşlayınız.");
                secim = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (secim==1);

            Console.ReadLine();
        }

        private static void Example1()
        {
            int sayi;
            //Console.WriteLine("3 haneli bir sayı giriniz.");
            //sayi = int.Parse(Console.ReadLine());
            //if (sayi<100 || sayi>999)
            //{
            //    Console.WriteLine("Sayı 3 haneli olmalıdır.");
            //    Console.ReadLine();
            //    //return yazarak methoddan cıkarttık yani bitirdik
            //    return;
            //}

            char cevap;
            do
            {
                do
                {
                    Console.WriteLine("3 haneli bir sayı giriniz.");
                    sayi = int.Parse(Console.ReadLine());

                } while (sayi < 100 || sayi > 999);
                Console.WriteLine("Tuttuğun sayıyı tersten düşün.");
                Console.ReadLine();
                Console.WriteLine("Büyük olan sayıdan küçük sayıyı çıkar.");
                Console.ReadLine();
                Console.WriteLine("Sonucun son rakamı ne?");
                int sonRakam = int.Parse(Console.ReadLine());
                switch (sonRakam)
                {
                    case 1:
                        Console.WriteLine("İşleminin sonucu 891.");
                        break;
                    case 2:
                        Console.WriteLine("İşleminin sonucu 122.");
                        break;
                    case 3:
                        Console.WriteLine("İşleminin sonucu 313.");
                        break;
                    case 4:
                        Console.WriteLine("İşleminin sonucu 424.");
                        break;
                    case 5:
                        Console.WriteLine("İşleminin sonucu 495.");
                        break;
                    case 6:
                        Console.WriteLine("İşleminin sonucu 396.");
                        break;
                    case 7:
                        Console.WriteLine("İşleminin sonucu 297.");
                        break;
                    case 8:
                        Console.WriteLine("İşleminin sonucu 198.");
                        break;
                    case 9:
                        Console.WriteLine("İşleminin sonucu 099.");
                        break;
                    case 0:
                        Console.WriteLine("İşleminin sonucu 000.");
                        break;

                    default:
                        Console.WriteLine("Son rakamı girdiğinizden emin olunuz.");
                        break;
                }
                Console.WriteLine("Devam etmek istiyor musunuz?(e/h)");
                cevap = Convert.ToChar(Console.ReadLine());

            } while (cevap == 'e');
        }
    }
}
