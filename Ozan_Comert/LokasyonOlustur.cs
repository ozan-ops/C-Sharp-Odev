using System;
using System.Collections.Generic;
using System.IO;

namespace Ozan_Comert
{
    internal class LokasyonOlustur : ILokasyon
    {
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Havalimanı { get; set; }

        public List<string> LokasyonList = new List<string>();

        private string FilePath = @"lokasyon.txt";
        private string TLokasyon = string.Empty;

        public LokasyonOlustur()
        {
            if (File.Exists(FilePath))
            {
                StreamReader reader = new StreamReader(FilePath);

                while (true)
                {
                    string[] Dlist;

                    string satir = reader.ReadLine();

                    if (satir != null)
                    {
                        Dlist = satir.Split(',');

                        Ulke = Dlist[0];
                        Sehir = Dlist[1];
                        Havalimanı = Dlist[2];

                        TLokasyon = Ulke + " - " + Sehir + " - " + Havalimanı;
                        LokasyonList.Add(TLokasyon);
                    }
                    else
                        break;
                }
            }
            else
            {
                Ulke = "Türkiye";
                Sehir = "İstanbul";
                Havalimanı = "Atatürk Havalimanı";

                TLokasyon = Ulke + " - " + Sehir + " - " + Havalimanı;
                LokasyonList.Add(TLokasyon);
            }
        }
    }
}
