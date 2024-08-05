using System;

    namespace KampIntro
    {

        class Program
        {
            static void Main(string[] args)
            {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            bool sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Kayıt ol!");
            }
            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("acalış butonu");
            }
            else
            {
                Console.WriteLine("Eşit Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
        }
        }
    }