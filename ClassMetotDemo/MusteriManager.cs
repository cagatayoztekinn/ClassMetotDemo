using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Eklendi ." + musteri.Adi + " " + musteri.Soyadi + " " + musteri.TC + " " + musteri.Parola);

        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müsteriler Listelendi." + musteri.Adi);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi." + musteri.Adi + " " + musteri.Soyadi + " " + musteri.TC + " " + musteri.Parola);
        }
    }
}
