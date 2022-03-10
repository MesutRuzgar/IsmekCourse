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
            Console.WriteLine("Bir sayı giriniz.");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            if (sayi1>0)
            {
                Console.WriteLine("{0} Sayısı pozitiftir.",sayi1);
            }
            else if (sayi1<0)
            {
                Console.WriteLine("{0} Sayısı  negatiftir.", sayi1);
            }
            else
            {
                Console.WriteLine("0 sayısı girildi.");
            }
            Console.ReadLine();
        }
    }
}
