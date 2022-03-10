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


            Console.ReadLine();
        }
    }
}
