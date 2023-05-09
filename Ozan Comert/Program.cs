using System;

namespace Ozan_Comert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rezervasyon Sistemi";

            Console.WriteLine("Rezervasyon Sistemine Hoş Geldiniz.\n");

            MusteriOlustur musteriOlustur = new MusteriOlustur();
            Musteri musteri = musteriOlustur.musteri();

            UcusOlustur ucusOlustur = new UcusOlustur(musteri.Ad, musteri.Soyad);
            Console.Write(ucusOlustur.UcusDondur());

            Console.Write("\n\nİyi Günler Dileriz.");

            Console.ReadKey();
        }
    }
}
