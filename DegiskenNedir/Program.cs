using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Mesut";
            int tamSayi = 10;
            double ondalikli=15.2;
            DateTime tarih = DateTime.Now;
            bool cevap = true;

            Console.WriteLine(isim);
            Console.WriteLine(tamSayi);
            Console.WriteLine(ondalikli);
            Console.WriteLine(tarih);

            Console.WriteLine(cevap);

            Console.ReadLine();
        }

    }

}
