using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sevgili kursiyer, hangi şehirde yaşıyorsun?");
            string sehir =Console.ReadLine();
            //Console.WriteLine(sehir+" şehrinin il plaka kodu nedir?");
            Console.WriteLine("{0} şehrinin il plaka kodu nedir?",sehir);
            int plaka=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} şehrinin il plaka kodu= {1}",sehir,plaka);
            string tarih=Convert.ToString(DateTime.Now);
            Console.WriteLine(tarih);
            Console.ReadKey();

        }

    }
}
