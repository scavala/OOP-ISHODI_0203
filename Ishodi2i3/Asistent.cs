using System;
using System.Collections.Generic;
using System.Text;

namespace Ishodi2i3
{
    class Asistent : Person, INterfaceGodinestazaitd
    {

        private static int index;
        private readonly int id;
        public Asistent(string firstName, string lastName, string titula, int godinestaza) : base(firstName, lastName)
        {
            id = ++index;
            KolekcijaKolegija = new List<Kolegij>();
            KolekcijaProfesoraZaKojeRadi = new List<Profesor>();
            Titula = titula;
            Godinestaza = godinestaza;
        }

        public string Titula { get; set; }
        public int Godinestaza { get; set; }
        public List<Profesor> KolekcijaProfesoraZaKojeRadi { get; set; }
        public List<Kolegij> KolekcijaKolegija { get; set; }




        public void DodajKolegij(Kolegij other)=>KolekcijaKolegija.Add(other);
        public void DodajProfesoraZaKojegRadi(Profesor other)=>KolekcijaProfesoraZaKojeRadi.Add(other);
        public void IspraviRok(IspitniRok i) => i.ispravi();
        public void IspravProvjeruk(KontinuiranaProvjera k)=>k.ispravi();
        public override string ToString() => $"{base.ToString()}, Id: {id} , Titula: {Titula}, Godine staza: {Godinestaza}";




    }
}
