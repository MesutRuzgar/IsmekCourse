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
            //StringMethods();
            //DateTimeMethods();
            //IlkMetodum();
            //MyMethodsExample();
            //myMethodsExample2();

            Console.WriteLine("Kısa kenarı giriniz:");
            int kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenarı giriniz:");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());

            CevreHesapla(kisaKenar,uzunKenar);
            int alan=AlanHesapla(kisaKenar, uzunKenar);
            Console.WriteLine("Alan:{0}",alan);


            Console.ReadLine();
        }

        static void CevreHesapla(int sayi1, int sayi2)
        {
            int cevre = 2 * (sayi1+sayi2);
            Console.WriteLine("Çevresi:{0}",cevre);


        }
        static int AlanHesapla(int sayi1,int sayi2)
        {
            int alan = sayi1 * sayi2;
            return alan;
        }

        private static void myMethodsExample2()
        {
            int cevap = KareninAlanınıHesaplama();
            Console.WriteLine("Karenin alanı:{0}", cevap);
        }

        static int KareninAlanınıHesaplama()
        {
            Console.WriteLine("Hesaplamak istediğiniz karenin uzunluğunu giriniz");
            int kenar = Convert.ToInt32(Console.ReadLine());
            int alan = kenar * kenar;
            return alan;
        }

        private static void MyMethodsExample()
        {
            Console.WriteLine("Tarih bilgisini görmek için 1'e,\nSaat bilgisini görmek için 2'ye basınız");
            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    TarihGoster();
                    break;
                case 2:
                    SaatGoster();
                    break;
                default:
                    Uyari();
                    break;
            }
        }

        static void TarihGoster()
        {
            Console.WriteLine(Convert.ToString(DateTime.Now.Date));
        }
        static void SaatGoster()
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
        }
        static void Uyari()
        {
            Console.WriteLine("Geçerli seçim yapılmadı!");
        }




        //main method static olduğundan içinde kullanılan methodlarda static olmak zorundadır
        static void IlkMetodum()
        {
            Console.WriteLine("Bu bilgi bir metod çalıştırılması ile yazılmıştır.");
        }

        private static void DateTimeMethods()
        {
            DateTime tarih = new DateTime(2010, 10, 24, 12, 00, 10);
            Console.WriteLine("Kendi oluşturduğum tarih:{0}", tarih);

            DateTime suan = DateTime.Now;
            Console.WriteLine("şuan:{0}", suan);
            int yıl = DateTime.Now.Year;
            Console.WriteLine("suanki yıl:{0}", yıl);
            int ay = DateTime.Now.Month;
            Console.WriteLine("suanki ay:{0}", ay);
            int ayınKacı = DateTime.Now.Year;
            Console.WriteLine("suanki ayın kacı:{0}", ayınKacı);
            DayOfWeek haftaninGunu = DateTime.Now.DayOfWeek;
            Console.WriteLine("suanki haftanın günü:{0}", haftaninGunu);
            int yilinKacıncıGunu = DateTime.Now.DayOfYear;
            Console.WriteLine("suanki yılın kacıncı günü:{0}", yilinKacıncıGunu);
            int saat = DateTime.Now.Hour;
            Console.WriteLine("suanki saat:{0}", saat);
            int dakika = DateTime.Now.Minute;
            Console.WriteLine("suanki dakika:{0}", dakika);
            DateTime bugün = DateTime.Today;
            Console.WriteLine("bugün:{0}", bugün);

            DateTime ucGunSonrası = tarih.AddDays(3);
            Console.WriteLine("enbaskataki tarihe 3 gün ekledik:{0}", ucGunSonrası);

            //iki tarihi çıkartır
            Console.WriteLine("iki tarih çıkartma:{0}", tarih.Subtract(DateTime.Now));

            Console.WriteLine(DateTime.Now.ToString("dd MMM yyyy HH:mm:ss"));
        }

        private static void StringMethods()
        {
            string metin = "Korkma, sönmez bu şafaklarda yüzen al sancak";
            int karakterSayisi = metin.Length;
            string kopyaMetin = string.Copy(metin);

            bool kelimeVarMi = metin.Contains("korkma"); //true yada false döner. içinde varmı diye aratır

            bool nvileBiterMi = metin.EndsWith(";");

            //bendekiyle gelen eşit mi diye kontrol eder
            bool esitMi = metin.Equals("İstiklar Marşı");

            int sIndex = metin.IndexOf("s");

            string buyukHarfliMetin = metin.ToUpper();
            string kucukHarfliMetin = metin.ToLower();

            //insert ile istediğimiz index numarasına göre ekleme yapabiliriz
            //metin+= "...." diyerek te sonuna ekleyebiliriz istersek
            string yeniMetin = metin.Insert(metin.Length - 1, "Sönmeden yurdumun üstünde tüten en son ocak.");
            metin += "O benim milletimin yıldızıdır parlayak;;;";
            metin = metin.Remove(metin.Length - 2);

            //boşluk olan yeri _ yapıyoruz
            metin = metin.Replace(" ", "_");

            //metni kelimelere parçalama
            string[] kelimeler = metin.Split('_');
            foreach (var item in kelimeler)
            {
                Console.WriteLine("parçalanan metin");
                Console.WriteLine(item);
            }

            char[] ilkKelimelerinKarakterleri = kelimeler[0].ToCharArray();
            foreach (var item in ilkKelimelerinKarakterleri)
            {
                Console.WriteLine("ilk kelimelerin karakterleri");
                Console.WriteLine(item);
            }

            //boşlukları silmemize yarar
            metin.Trim();

            //split herhangi bir özel karaktere göre sürekli böler
            //substring ise isteğimiz index arasındaki bilgileri kesip alır
            string parcalananMetin = metin.Substring(20, 10);
            Console.WriteLine("substring ile Parçalanan metin:{0}", parcalananMetin);

            Console.WriteLine("Metnin karakter sayısı:{0}", karakterSayisi);
            Console.WriteLine("kopya metin:{0}", kopyaMetin);
            Console.WriteLine("korkma kelime varmi:{0}", kelimeVarMi);
            Console.WriteLine("; ile biter mi:{0}", nvileBiterMi);
            Console.WriteLine("istiklal marşına eşit mi:{0}", esitMi);
            Console.WriteLine("S nin indeksi:{0}", sIndex);
            Console.WriteLine("büyük harfli metin:{0}", buyukHarfliMetin);
            Console.WriteLine("küçük harfli metin:{0}", kucukHarfliMetin);
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
