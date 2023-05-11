using System;
using System.Collections;

namespace Ozan_Comert
{
    internal class UcusOlustur
    {
        public string Musteri;
        public string Ucak;
        public string Lokasyon;
        public DateTime Tarih;
        public int KoltukSayisi;

        Random random = new Random();

        public UcusOlustur(string Ad, string Soyad)
        {
            Musteri = Ad + " " + Soyad;

            UcakOlustur ucakOlustur = new UcakOlustur();
            Ucak = ucakOlustur.Model;

            Console.WriteLine("\nAktif Uçuşlar: ");
            LokasyonOlustur lokasyonOlustur = new LokasyonOlustur();

            int LSayac = 1;
            foreach (var item in lokasyonOlustur.LokasyonList)
            {
                Console.WriteLine(LSayac + ". Lokasyon => " + item);
                LSayac++;
            }

            while (true)
            {
                Console.Write("Lokasyon Seçiniz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim >= 1 && secim <= 9)
                {
                    Lokasyon = lokasyonOlustur.LokasyonList[secim - 1];
                    break;
                }
            }

            Console.WriteLine("\nAktif Tarihler: ");

            int TSayac = 1;
            DateTime[] dates = TarihOlustur();
            foreach (DateTime date in dates)
            {
                Console.WriteLine(TSayac + ". Tarih => " + date.ToString("dd/MM/yyyy"));
                TSayac++;
            }

            while (true)
            {
                Console.Write("Tarih Seçiniz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim >= 1 && secim <= 14)
                {
                    Tarih = dates[secim - 1];
                    break;
                }
            }

            int max = random.Next(ucakOlustur.YolcuKapasitesi / 2, ucakOlustur.YolcuKapasitesi);
            max = max - random.Next(1, max);
            KoltukSayisi = KoltukSecim(max);
        }

        public string UcusDondur()
        {
            Rezervasyon rezervasyon = new Rezervasyon();

            string Temp = "\nSayın " + Musteri + ";\nUçağınız: " + Ucak + "\nLokasyonunuz: " + Lokasyon + "\nUçuş Tarihiniz: " + Tarih + "\nKoltuğunuz: " + KoltukSayisi + "\nÜcretiniz: " + rezervasyon.ucret;
            return Temp;
        }

        public DateTime[] TarihOlustur()
        {            
            DateTime[] dates = new DateTime[14];
            DateTime now = DateTime.Now;

            for (int i = 0; i < dates.Length; i++)
            {
                dates[i] = now.AddDays(i + 1);
            }

            return dates;
        }

        public int KoltukSecim(int max)
        {
            int secim;

            ArrayList koltuklar = new ArrayList();
            int j = random.Next(1, max);

            Console.Write("\nAktif Koltuklar: ");

            for (int i = 1; i <= max; i+=j)
            {
                koltuklar.Add(i);
                Console.Write(i + " ");
            }

            Console.Write("\nKoltuk Seçiniz: ");
            secim = Convert.ToInt32(Console.ReadLine());

            while(!koltuklar.Contains(secim))
            {
                Console.WriteLine("Yanlış Değer");

                Console.Write("Aktif Koltuklar: ");

                foreach (var item in koltuklar)
                {
                    Console.Write(item + " ");
                }

                Console.Write("\nKoltuk Seçiniz: ");
                secim = Convert.ToInt32(Console.ReadLine());
            }

            return secim;
        }
    }
}
