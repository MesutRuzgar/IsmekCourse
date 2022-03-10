using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            //Console.WriteLine("3 haneli bir sayı giriniz.");
            //sayi = int.Parse(Console.ReadLine());
            //if (sayi<100 || sayi>999)
            //{
            //    Console.WriteLine("Sayı 3 haneli olmalıdır.");
            //    Console.ReadLine();
            //    //return yazarak methoddan cıkarttık yani bitirdik
            //    return;
            //}

            char cevap;
            do
            {
                do
                {
                    Console.WriteLine("3 haneli bir sayı giriniz.");
                    sayi = int.Parse(Console.ReadLine());

                } while (sayi < 100 || sayi > 999);
                Console.WriteLine("Tuttuğun sayıyı tersten düşün.");
                Console.ReadLine();
                Console.WriteLine("Büyük olan sayıdan küçük sayıyı çıkar.");
                Console.ReadLine();
                Console.WriteLine("Sonucun son rakamı ne?");
                int sonRakam = int.Parse(Console.ReadLine());
                switch (sonRakam)
                {
                    case 1:
                        Console.WriteLine("İşleminin sonucu 891.");
                        break;
                    case 2:
                        Console.WriteLine("İşleminin sonucu 122.");
                        break;
                    case 3:
                        Console.WriteLine("İşleminin sonucu 313.");
                        break;
                    case 4:
                        Console.WriteLine("İşleminin sonucu 424.");
                        break;
                    case 5:
                        Console.WriteLine("İşleminin sonucu 495.");
                        break;
                    case 6:
                        Console.WriteLine("İşleminin sonucu 396.");
                        break;
                    case 7:
                        Console.WriteLine("İşleminin sonucu 297.");
                        break;
                    case 8:
                        Console.WriteLine("İşleminin sonucu 198.");
                        break;
                    case 9:
                        Console.WriteLine("İşleminin sonucu 099.");
                        break;
                    case 0:
                        Console.WriteLine("İşleminin sonucu 000.");
                        break;

                    default:
                        Console.WriteLine("Son rakamı girdiğinizden emin olunuz.");
                        break;
                }
                Console.WriteLine("Devam etmek istiyor musunuz?(e/h)");
                cevap = Convert.ToChar(Console.ReadLine());

            } while (cevap=='e');
            Console.ReadLine();
        }
    }
}
