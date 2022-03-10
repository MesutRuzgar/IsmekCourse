using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethods
{
    class Program
    {
        //kendi kendini tekrar eden methodun içinded yine aynı işlemin gerçekleşmesi gereken durumlarda kullanılır.
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Faktoriyel hesaplamak istediğiniz sayıyı giriniz:");
            sayi = int.Parse(Console.ReadLine());

            int faktoriyel = FaktoriyelHesapla(sayi);
            Console.WriteLine(faktoriyel);
            Console.ReadLine();
        }

        //özyinelemeli method örneği
        static int FaktoriyelHesapla(int sayi)

        {
            if (sayi<=1)
            {
                return 1;
            }
            else
            {
                return sayi * FaktoriyelHesapla(sayi - 1);
            }

        }
    }
}
