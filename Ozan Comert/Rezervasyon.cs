using System;

namespace Ozan_Comert
{
    internal class Rezervasyon
    {
        public int ucret;

        Random random = new Random();

        public Rezervasyon()
        {
            ucret = Convert.ToInt32(random.Next(1000, 70000));
        }
    }
}
