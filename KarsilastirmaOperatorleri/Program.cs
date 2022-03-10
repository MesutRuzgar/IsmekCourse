using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorleri
{
    class Program
    {
        //== eşittir
        //< küçüktür
        //> büyüktür
        //<= küçük eşittir
        //>= büyük eşittir
        //! değildir
        //!= eşit değildir
        static void Main(string[] args)
        {
            //IfElseIntro();
            //IfElseExample();
            //SwitchCaseIntro();

            Console.ReadLine();
        }

        private static void SwitchCaseIntro()
        {
            Console.WriteLine("Lütfen bir harf giriniz.");
            string harf = Console.ReadLine();

            switch (harf)
            {
                case "a":
                    Console.WriteLine("Ahmet, Ali, Ayşe, Aslı, Aydın");
                    break;
                case "b":
                    Console.WriteLine("Betül, Büşra, Barış, Berra, Burak");
                    break;
                case "c":
                    Console.WriteLine("Ceyda, Ceren, Cemre, Cemal, Cem");
                    break;
                case "d":
                    Console.WriteLine("Deniz, Derya, Damla, Dilek, Dinçer");
                    break;
                default:
                    Console.WriteLine("Bu karakterle uyuşan isim bulunamadı");
                    break;
            }
        }

        private static void IfElseExample()
        {
            Console.WriteLine("Vize notunuzu giriniz.");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz.");
            int final = Convert.ToInt32(Console.ReadLine());

            double basariNotu = vize * 0.4 + final * 0.6;
            Console.WriteLine(basariNotu);

            if (basariNotu >= 60)
            {
                Console.WriteLine("Geçti");
            }
            else if (basariNotu >= 50)
            {
                Console.WriteLine("Şartlı geçti.");

            }
            else
            {
                Console.WriteLine("Kaldı.");
            }
        }

        private static void IfElseIntro()
        {
            Console.WriteLine("Bir sayı giriniz.");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > 0)
            {
                Console.WriteLine("{0} Sayısı pozitiftir.", sayi1);
            }
            else if (sayi1 < 0)
            {
                Console.WriteLine("{0} Sayısı  negatiftir.", sayi1);
            }
            else
            {
                Console.WriteLine("0 sayısı girildi.");
            }
        }
    }
}
