using System;

namespace Ozan_Comert
{
    internal interface IUcak
    {
        string Model { get; set; }
        int YolcuKapasitesi { get; set; }
        int BagajKapasitesi { get; set; }
        int MotorSayisi { get; set; }
        int Hiz { get; set; }
    }
}
