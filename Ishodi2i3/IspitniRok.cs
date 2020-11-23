using System;
using System.Collections.Generic;
using System.Text;

namespace Ishodi2i3
{
    class IspitniRok:IIspravljen
    {

        private static int index;
        private readonly int id;


        public IspitniRok(string vrijemeOdrzavanja, Kolegij kolegij)
        {
            id = ++index;
            VrijemeOdrzavanja = vrijemeOdrzavanja;
            Kolegij = kolegij;
        }

        public string VrijemeOdrzavanja { get; set; }
        public Kolegij Kolegij { get; set; }
        public bool Ispravljen { get; private set; }
        public void ispravi() => Ispravljen = true;
        public override string ToString()=>$" ID: {id}, Kolegij: {Kolegij.Naziv}, vrijeme odrzavanja: {VrijemeOdrzavanja} Ispravljen: {(Ispravljen?"da":"ne")}";
        
    }
}
