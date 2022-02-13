using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAdi + "  "+musteri.musteriSoyadi + " "+"Müşteri eklendi");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAdi + "   "+musteri.musteriSoyadi+" "+"Müşteri silindi");
            
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
              Console.WriteLine(musteri.musteriAdi + "  " + musteri.musteriSoyadi + "  " + musteri.Id + "  " + musteri.musteriTelefon);
            }
            
        }
    }
}
