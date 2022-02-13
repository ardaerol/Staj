using System;

namespace staj1gun
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "kategori";
            int ogrenciSAyisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            string[] kurslar = new string[] { "a", "b", "c", "d" };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            };
            class Kurs
            {
            public int MyProperty { get; set; }
        }

        }
    }
}
