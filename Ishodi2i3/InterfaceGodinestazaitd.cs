using System;
using System.Collections.Generic;
using System.Text;

namespace Ishodi2i3
{
    interface INterfaceGodinestazaitd
    {

        public string Titula { get; set; }
        int Godinestaza { get; set; }
        List<Kolegij> KolekcijaKolegija { get; set; }
        void DodajKolegij(Kolegij  other);
       
    }
}
