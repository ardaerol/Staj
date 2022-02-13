using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriAdi = "Arda";
            musteri1.musteriSoyadi = "Erol";
            musteri1.Id = 1;
            musteri1.musteriTelefon = 5061542230;

            Musteri musteri2 = new Musteri();
            musteri2.musteriAdi = "Vehbi";
            musteri2.musteriSoyadi = "Erol";
            musteri2.Id = 2;
            musteri2.musteriTelefon = 5325975128;

            Musteri musteri3 = new Musteri();
            musteri3.musteriAdi = "Derya";
            musteri3.musteriSoyadi = "Erol";
            musteri3.Id = 3;
            musteri3.musteriTelefon = 5057584435;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteri = new MusteriManager();
            musteri.Ekle(musteri1);
            musteri.Silme(musteri2);
            musteri.Listele(musteriler);

        }
    }
}
