using System;

namespace EloadasProject
{
    class Eloadas
    {
        private bool[,] foglalasok;
        static void Main(string[] args)
        {
            
        }

        public Eloadas(int sorokSzama,int helyekSzama)
        {
            if (sorokSzama > 0 && helyekSzama > 0)
            {
                foglalasok = new bool[sorokSzama,helyekSzama];
            }
            else
            {
                ArgumentException e;
            }
        }
        public bool Lefoglal()
        {
            return false;
        }
        public int SzabadHelyek { get; }
        public bool Teli()
        {
            return false;
        }
        public bool Foglalt(int sorSzam, int helySzam)
        {
            if (sorSzam > 0 && helySzam > 0)
            {

            }
            else
            {
                ArgumentException e;
            }
            return false;
        }

    }
}
