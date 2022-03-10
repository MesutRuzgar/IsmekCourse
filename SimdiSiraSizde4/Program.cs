using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimdiSiraSizde4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Cümle giriniz.");
                string cumle = Console.ReadLine().Trim();
                string[] kelimeler = cumle.Split(' ');
                string yeniCumle = "";
                foreach (var item in kelimeler)
                {
                    string yeniKelime = HarfBuyuten(item);
                    yeniCumle += " " + yeniKelime;
                }
                Console.WriteLine(yeniCumle);

                if (i<2)
                {
                    Console.WriteLine("Yeni bir cümle girmek ister misiniz?(e/h)");
                    char cevap = Convert.ToChar(Console.ReadLine());
                    if (cevap=='h')
                    {
                        break;
                    }
                }
            }
           

            
        
        }

        static string HarfBuyuten(string kelime)
        {

            string yeniKelime = "";
            yeniKelime = kelime.Substring(0, 1).ToUpper() + kelime.Substring(1, kelime.Length - 2).ToLower() + kelime.Substring(kelime.Length - 1).ToUpper();
            return yeniKelime;           

        }
    }
}
