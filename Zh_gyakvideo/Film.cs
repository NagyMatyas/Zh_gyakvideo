using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_gyakvideo
{
    class Film
    {
        public string Cim { get; }
        protected int Ar { get; }
        public double Atlag { get { return AtlagSzamitas(); } }

        private int ertekDarab = 0;
        private int[] ertekek = new int[10];

        public Film(string cim, int ar)
        {
            Cim = cim;
            Ar = ar;
        }

        public virtual void Ertekel(int ertek)
        {
            if(ertekDarab >= 10)
            {
                throw new UjErtekelesHiba(this, ertek);
            }

            if(1 <= ertek && ertek <= 5)
            {
                ertekek[ertekDarab] = ertek;
                ertekDarab++;
            }
        }

        private double AtlagSzamitas()
        {
            if (ertekDarab == 0)
                throw new AtlagSzamitasHiba(this);

            int szumma = 0;

            for (int i = 0; i < ertekDarab; i++)
            {
                szumma += ertekek[i];
            }

            return szumma / ertekDarab;
        }
    }
}
