using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string Adi = "Cagatay";
            string Soyadi = "Oztekin";
            int TC = 458118351;



            string[] Musteri = new string[] {"Cagatay"};
            Musteri musteri1 = new Musteri();

            musteri1.Adi = "Eren";
            musteri1.Soyadi = "OZTEKİN";
            musteri1.TC = 38101283;
            musteri1.Parola = 7182;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Elif";
            musteri2.Soyadi = "OZTEKİN";
            musteri2.TC = 38816152;
            musteri2.Parola = 9685;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Tamer";
            musteri3.Soyadi = "OZTEKİN";
            musteri3.TC = 15935782;
            musteri3.Parola = 4586;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.TC);
                Console.WriteLine(musteri.Parola);
                Console.WriteLine("------------------------");


            }
            Console.WriteLine("----------Metotlar--------------");



            MusteriManager musterimanager = new MusteriManager();

            musterimanager.MusteriEkle(musteri1);
            musterimanager.MusteriSil(musteri2);
            musterimanager.MusteriListele(musteri1);




            {

            }
        }




    }
        
    
}
