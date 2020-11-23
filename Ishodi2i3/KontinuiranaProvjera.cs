using System;
using System.Collections.Generic;
using System.Text;

namespace Ishodi2i3
{
    class KontinuiranaProvjera:IIspravljen
    {

        private static int index;
        private readonly int id;
        public KontinuiranaProvjera(Kolegij kolegij)
        {
            id = ++index;
            Kolegij = kolegij;
        }

        public Kolegij Kolegij { get; set; }
        public bool Ispravljena { get; private set; }
        public void ispravi() => Ispravljena = true;
    }
}
