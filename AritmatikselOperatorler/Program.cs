using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayıyı giriniz.");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz.");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplama sonucu={0}", toplam);
            int fark = sayi1 - sayi2;
            Console.WriteLine("Çıkartma sonucu={0}", fark);
            int carp = sayi1 * sayi2;
            Console.WriteLine("Çarpma sonucu={0}", carp);
            int bolum = sayi1 / sayi2;
            Console.WriteLine("Bölme sonucu={0}",bolum);
            //mod almak için => % yani bölümden kalanı bulmak için
            int mod = sayi1 % sayi2;
            Console.WriteLine("Mod yani bölümden kalan={0}",mod);

            Console.ReadLine();
        }
    }
}
