using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        
        //imza(signature), ad ve parametrelerini ifade eden bir kavrandır.
        //imza metodun geri dönüş tipini kapsamaz.
        //isimleri aynı imzaları farklı metodlara method overloading (metod aşırı yükleme) denir
        //aynı amaca hizmet eden farklı parametrelere göre farklı işlemler yaparak farklı çıktılar üretebilen metodlardır

        static void Main(string[] args)
        {
            string ad, soyad,cevap;
            Console.WriteLine("Lütfen adınızı giriniz");
            ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı giriniz.(isteğe bağlı)");
            soyad = Console.ReadLine();

            //string ifade bos mu veya bosluk varmı diye kontrol ediyor
            if (String.IsNullOrWhiteSpace(soyad))
            {
               cevap= Mesaj(ad);
            }
            else
            {
               cevap= Mesaj(ad, soyad);
            }
            Console.WriteLine(cevap);

            Console.ReadLine();

        }

        static string Mesaj(string ad)
        {
            string ilkHarf= ad.Substring(0, 1);
            string kelimeninDevami = ad.Substring(1);
            string buyukIlkHarf = ilkHarf.ToUpper();
            kelimeninDevami = kelimeninDevami.ToLower();
            string metin = "Sevgili " + buyukIlkHarf + kelimeninDevami + ", sistemimize hoşgeldiniz.";
            return metin;
        }
        static string Mesaj(string ad, string soyad)
        {
            string x = ad.Substring(0, 1);
            x = x.ToUpper();
            string y = ad.Substring(1);
            y = y.ToLower();
            string z = soyad.Substring(0, 1).ToUpper();
            string t = soyad.Substring(1).ToLower();

            string metin = "Sevgili " + x + y + " " + z + t + ", sistemimize hoşgeldiniz.";
            return metin;
        }
    }
}
