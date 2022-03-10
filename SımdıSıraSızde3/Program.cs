using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SımdıSıraSızde3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char cevap;
            
           

            do
            {
                int[] sayilar = new int[10];
                int pozitifSayi = 0;
                int negatifSayi = 0;
                int sifirSayisi = 0;
                Console.WriteLine("Lütfen 10 adet sayı giriniz.");
                for (int i = 0; i < 10; i++)
                {
                    //Console.WriteLine("{0}. sayıyı giriniz", i + 1);
                    sayilar[i] = int.Parse(Console.ReadLine());
                }
                foreach (var number in sayilar)
                {
                    if (number<0)
                    {
                        negatifSayi++;
                    }
                    else if (number==0)
                    {
                        sifirSayisi++;
                    }
                    else
                    {
                        pozitifSayi++;
                    }
                }
                Console.WriteLine("Tanımladığınız sayılardan {0} tanesi pozitif, {1} tanesi negatif, {2} tanesi 0'dır.", pozitifSayi, negatifSayi, sifirSayisi);
              

                Console.WriteLine("Tekrar etmek istiyor musunuz?(e/h)");
                cevap = Convert.ToChar(Console.ReadLine());

            } while (cevap=='e');
            Console.ReadLine();
        }
    }
}
