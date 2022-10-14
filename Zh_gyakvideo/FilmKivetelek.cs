using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_gyakvideo
{
    class FilmKivetelek : Exception
    {
        public Film Film { get; }

        public FilmKivetelek(Film film)
        {
            Film = film;
        }
    }
}
