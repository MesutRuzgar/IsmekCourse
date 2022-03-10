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

            Console.WriteLine("Vize notunuzu giriniz.");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz.");
            int final = Convert.ToInt32(Console.ReadLine());

            double basariNotu = vize * 0.4 + final * 0.6;
            Console.WriteLine(basariNotu);

            if (basariNotu>=60)
            {
                Console.WriteLine("Geçti");
            }
            else if (basariNotu>=50)
            {
                Console.WriteLine("Şartlı geçti.");

            }
            else
            {
                Console.WriteLine("Kaldı.");
            }

            Console.ReadLine();
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
