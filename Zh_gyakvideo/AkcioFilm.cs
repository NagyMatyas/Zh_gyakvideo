using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_gyakvideo
{
    class AkcioFilm : Film, IKorhatar
    {
        int alsoKorhatar;

        public AkcioFilm(string cim, int ar, int alsoKorhatar) : base(cim, ar)
        {
            this.alsoKorhatar = alsoKorhatar;
        }

        public int Korhatar => alsoKorhatar;

        public int Buntetes(int eletkor)
        {
            return (eletkor - alsoKorhatar) * Ar;
        }

        public override void Ertekel(int ertek)
        {
            if(ertek < 5)
            {
                base.Ertekel(ertek);
            }
        }
    }
}
