using System;

namespace Ozan_Comert
{
    internal class MusteriOlustur
    {
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public int Cinsiyet { get; set; }
        public int Engel { get; set; }

        public Musteri musteri()
        {
            while (true)
            {
                string Temp = string.Empty;

                Console.Write("T.C. Kimlik Numaranızı Giriniz: ");
                Temp = Console.ReadLine();

                if (Boyut_Kontrol(Temp) && Number_Kontrol(Temp))
                {
                    TC = Temp;
                    break;
                }
            }

            Console.Write("Adınızı Giriniz: ");
            Ad = Console.ReadLine();

            Console.Write("Soyadınızı Giriniz: ");
            Soyad = Console.ReadLine();

            while (true)
            {
                string Temp = string.Empty;

                Console.Write("Telefon Numaranızı Giriniz: ");
                Temp = Console.ReadLine();

                if (Boyut_Kontrol(Temp) && Number_Kontrol(Temp))
                {
                    Telefon = Temp;
                    break;
                }
            }

            while (true)
            {
                string Temp = string.Empty;

                Console.Write("Cinsiyetinizi Giriniz (e, k): ");
                Temp = Console.ReadLine().ToLower();

                if (Temp == "e")
                {
                    Cinsiyet = 1;
                    break;
                }
                else if (Temp == "k")
                {
                    Cinsiyet = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış Değer");
                }
            }

            while (true)
            {
                string Temp = string.Empty;

                Console.Write("Engel Durumunuz Var Mı? (e, h): ");
                Temp = Console.ReadLine().ToLower();

                if (Temp == "e")
                {
                    Engel = 1;
                    break;
                }
                else if (Temp == "h")
                {
                    Engel = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış Değer");
                }
            }

            Musteri musteri = new Musteri(TC, Ad, Soyad, Telefon, Cinsiyet, Engel);

            return musteri;
        }

        public bool Boyut_Kontrol(string deger)
        {
            bool Kontrol = false;

            if (deger.Length == 11)
            {
                Kontrol = true;
            }
            else
            {
                Console.WriteLine("Alan 11 Haneden Oluşmaktadır");
            }

            return Kontrol;
        }

        public bool Number_Kontrol(string deger)
        {
            bool Kontrol = false;

            try
            {
                Convert.ToInt64(deger);
                Kontrol = true;
            }
            catch
            {
                Console.WriteLine("Sayı Giriniz");
            }

            return Kontrol;
        }
    }
}
