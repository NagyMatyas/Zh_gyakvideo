using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_gyakvideo
{
    class UjErtekelesHiba : FilmKivetelek
    {
        public int Ertek { get; }

        public UjErtekelesHiba(Film film, int ertek) : base(film)
        {
            Ertek = ertek;
        }
    }
}
