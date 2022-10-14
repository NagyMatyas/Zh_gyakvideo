using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_gyakvideo
{
    class Program
    {
        static void Main(string[] args)
        {
            Film[] filmek = new Film[2];

            filmek[0] = new Film("Nem Dob Kivetelt (tul sok ertekelest megis)", 1500);
            filmek[1] = new AkcioFilm("Kivetelt Dobo film - nincs ertekelve", 1000, 16);

            double min = 5;
            Film minFilm;

            for (int i = 0; i < 10; i++)
            {
                filmek[0].Ertekel(3);
            }

            for (int i = 0; i < filmek.Length; i++)
            {
                try
                {
                    if (filmek[i].Atlag < min)
                    {
                        min = filmek[i].Atlag;
                        minFilm = filmek[i];
                    }
                }
                catch (AtlagSzamitasHiba abc)
                {
                    Console.WriteLine($"Film cime, aminek nincs ertelese: {abc.Film.Cim}");
                }
            }

            try
            {
                filmek[0].Ertekel(5);
            }
            catch (UjErtekelesHiba e)
            {
                Console.WriteLine($"Film cime, aminek tul sok az ertelese: {e.Film.Cim}, ertek:{e.Ertek}");
            }

            IKorhatar[] korhataros = new IKorhatar[3];

            korhataros[0] = (IKorhatar)filmek[1];

            korhataros[1] = new Puzzle();

            int buntetes = 0;
            int darab = 0;

            for (int i = 0; i < korhataros.Length; i++)
            {
                if(korhataros[i].Buntetes(18) > 0)
                {
                    darab++;
                }
                else
                {
                    buntetes += korhataros[i].Buntetes(18);
                }
            }
        }
    }
}
