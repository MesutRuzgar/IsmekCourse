using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //MathMethods();


            Console.ReadLine();
        }

        private static void MathMethods()
        {
            int enBuyuk = Math.Max(12, 18);
            Console.WriteLine(enBuyuk);
            int enKucuk = Math.Min(12, 18);
            Console.WriteLine(enKucuk);

            //bir üstteki sayıya yuvarlar
            Console.WriteLine("bir üstteki sayıya yuvarlama:{0}", Math.Ceiling(16.123));

            //mutlak değerini bulur
            Console.WriteLine("mutlak değer:{0}", Math.Abs(-2323));

            //en yakın tam sayıya yuvarlar. virgülden sonraki 3 basamağa duyarlı yaptık
            Console.WriteLine("En yakın tam sayı , den sonra 3 basamak:{0}", Math.Round(76.45646, 3));

            //taban değerine yuvarlama
            Console.WriteLine("taban değerine yuvarlama:{0}", Math.Floor(16.123));

            //karekökünü almak için
            Console.WriteLine("karekök:{0}", Math.Sqrt(5));

            //kuvvet alma
            Console.WriteLine("kuvvet alma:{0}", Math.Pow(8, 3));

            //sinüs
            Console.WriteLine("sinüs:{0}", Math.Sin(30));

            //logaritma
            Console.WriteLine("Logaritma:{0}", Math.Log(10));

            Console.WriteLine("E sayısı:{0}", Math.E);
            Console.WriteLine("Pi sayısı:{0}", Math.PI);
        }
    }
}
