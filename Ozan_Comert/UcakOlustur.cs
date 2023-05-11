using System;

namespace Ozan_Comert
{
    internal class UcakOlustur : IUcak
    {
        public string Model { get; set; }
        public int YolcuKapasitesi { get; set; }
        public int BagajKapasitesi { get; set; }
        public int MotorSayisi { get; set; }
        public int Hiz { get; set; }

        private Random Random = new Random();

        public UcakOlustur()
        {
            int random = Random.Next(0, 3);

            switch (random)
            {
                case 0:
                    Model = "Airbus A320";
                    YolcuKapasitesi = 180;
                    BagajKapasitesi = 4000;
                    MotorSayisi = 2;
                    Hiz = 850;
                    break;

                case 1:
                    Model = "Boeing 737";
                    YolcuKapasitesi = 200;
                    BagajKapasitesi = 5000;
                    MotorSayisi = 2;
                    Hiz = 900;
                    break;

                case 2:
                    Model = "Boeing 777";
                    YolcuKapasitesi = 350;
                    BagajKapasitesi = 7000;
                    MotorSayisi = 4;
                    Hiz = 950;
                    break;

                default:
                    break;
            }
        }
    }
}
