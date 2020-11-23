using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ishodi2i3
{
    class Student : Person
    {
        
        private static int index;
        private readonly int id;
        private string jmbag;

        private List<IspitniRok> PrijavljeniRokovi { get; set; }
        public int GodinaStudija { get; set; }

        public Student(string firstName, string lastName, string jMBAG, int godinaStudija) : base(firstName, lastName)
        {
            PrijavljeniRokovi = new List<IspitniRok>();

            id = ++index;
            JMBAG = jMBAG;
            GodinaStudija = godinaStudija;
        }


        public string JMBAG
        {
            get => jmbag;
            set
            {
                if ((value.ToString().Length != 10) || !(value.ToString().All(char.IsDigit)))
                {
                    throw new Exception("Uneseni JMBAG nema 10 znamenki");
                }
                jmbag = value;
            }
        }


        public void PrijaviRok(IspitniRok i)
        {
            PrijavljeniRokovi.Add(i);
            i.Kolegij.Profesor.DodajUkolekciju(jmbag, i);
        }
        public void OdjaviRok(int index)=> PrijavljeniRokovi.RemoveAt(index-1);
        public void IspisPrijavljenihRokova()=>PrijavljeniRokovi.ForEach(Console.WriteLine);
        public override string ToString() => $"{base.ToString()}, Id: {id} , JMBAG: {jmbag}, Godina studija: {GodinaStudija}";

    }
}
