using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +" "+ musteri.SoyAdi +"müşteri eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + musteri.SoyAdi + "müşteri silindi");

        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id+ " " + musteri.Adi + " " + musteri.SoyAdi+ " " + musteri.Telefon);
            }
        }

    }
}
