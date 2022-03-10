using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoopIntro();
            //WhileLoopIntro();
            //FaktoriyelExample();
            //DoWhileExample();

            int sayi = new Random().Next(0, 100);
            int tahmin=0;
            do
            {
                Console.WriteLine(sayi);
                Console.WriteLine("Tuttuğum sayıyı tahimin ediniz");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin>sayi)
                {
                    Console.WriteLine("Aşağıya in");
                }
                else if (tahmin<sayi)
                {
                    Console.WriteLine("Yukarı çık");
                }

            } while (tahmin!=sayi);


            Console.ReadLine();
        }

        private static void DoWhileExample()
        {
            int sayi;
            do
            {
                sayi = new Random().Next(0, 10);
                Console.WriteLine(sayi);
            } while (sayi != 5);
        }

        private static void FaktoriyelExample()
        {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int fac = 1;

            while (sayi > 1)
            {
                fac = sayi * fac;
                sayi--;
            }
            Console.WriteLine("Faktoriyel:{0}", fac);
        }

        private static void WhileLoopIntro()
        {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi != 0)
            {
                Console.WriteLine("Lütfen yeni bir sayı giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("0 girildiği için döngü bitirildi.");
        }

        private static void ForLoopIntro()
        {
            Console.WriteLine("Başlangıç Sayısını giriniz");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş Sayısını giriniz");
            int bitis = Convert.ToInt32(Console.ReadLine());

            if (baslangic < bitis)
            {
                for (int i = baslangic; i <= bitis; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (baslangic > bitis)
            {
                for (int i = baslangic; i >= bitis; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Başlangıç ve bitiş noktası eşit");
            }
        }
    }
}
