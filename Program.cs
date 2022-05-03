using System;

namespace Static_Sinif_Ve_Uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz", "Arda", "IK");
            Calisan calisan2 = new Calisan("Zikriye", "Ürkmez", "IK");
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);
            Islemler.Topla(100,200);
            Console.WriteLine("Toplama İşlemi Sonucu:{0}",Islemler.Topla(100,200));
            Islemler.Cikar(400,50);
            Console.WriteLine("Çıkarma İşlemi Sonucu:{0}",Islemler.Cikar(400,50));

        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }
        private string Isim;
        private string Soyisim;

        private string Departman;


        //Burayı 1 kere çalıştırır ondan sonraki her nesne oluşturulduğunda diğer constructor'ı çalıştırır.
        static Calisan()
        {
            calisanSayisi = 0;

        }
        public Calisan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }
     static class Islemler
     {
       public static long Topla(int sayi1,int sayi2)
       {
           return sayi1+sayi2;
       }
       public static long Cikar(int sayi1,int sayi2)
       {
           return sayi1-sayi2;
       }
     }

}
