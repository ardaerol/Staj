using System;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Arda";
            musteri1.SoyAdi = "Erol";
            musteri1.Telefon = 5061542230;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Vehbi";
            musteri2.SoyAdi = "Erol";
            musteri2.Telefon = 5325975128;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Derya";
            musteri3.SoyAdi = "Erol";
            musteri3.Telefon = 5057584435;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteri = new MusteriManager();
            musteri.Ekle(musteri1);
            musteri.Ekle(musteri2);
            musteri.Ekle(musteri3);
            musteri.Sil(musteri1);
            musteri.Listele(musteriler);

        }
    }
}
