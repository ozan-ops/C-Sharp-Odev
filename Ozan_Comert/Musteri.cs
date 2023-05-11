using System;

namespace Ozan_Comert
{
    internal class Musteri
    {
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public int Cinsiyet { get; set; }
        public int Engel { get; set; }

        public Musteri(string tc, string ad, string soyad, string telefon, int cinsiyet, int engel)
        {
            TC = tc;
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
            Cinsiyet = cinsiyet;
            Engel = engel;
        }
    }
}
