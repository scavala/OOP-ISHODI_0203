using System;
using System.Collections.Generic;
using System.Text;

namespace Ishodi2i3
{
    class Kolegij
    {

        private static int index;
        private readonly int id;

        public Kolegij(string naziv, int brojECTS, Profesor profesor)
        {
            id = ++index;
            Naziv = naziv;
            BrojECTS = brojECTS;
            Profesor = profesor;
        }


        public Profesor Profesor { get; set; }
        public int BrojECTS { get; set; }
        public string Naziv { get; set; }
        public override string ToString()=> $"ID:{id}, Naziv: {Naziv}, ECTS:{BrojECTS}, Profesor:{Profesor}";
        
    }
}
