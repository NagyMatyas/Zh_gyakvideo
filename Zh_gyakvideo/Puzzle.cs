using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_gyakvideo
{
    class Puzzle : IKorhatar
    {
        public int Darab { get; }

        public int Korhatar => Darab / 500;

        public int Buntetes(int eletkor)
        {
            return (eletkor - Korhatar) * 1000;
        }
    }
}
