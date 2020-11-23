using System;
using System.Collections.Generic;
using System.Text;

namespace Ishodi2i3
{
    class Profesor : Person, INterfaceGodinestazaitd,IDodajUKolekciju
    {


        private static int index;
        private readonly int id;
        public Profesor(string firstName, string lastName, string titula, int godinestaza) : base(firstName, lastName)
        {
            id = ++index;
            KolekcijaKolegija = new List<Kolegij>();
            KolekcijaAsistenataKojiRadeZaNjega = new List<Asistent>();
            KolekcijaSvihPrijavljenihIspitaaa = new List<KeyValuePair<string, IspitniRok>>();
            Titula = titula;
            Godinestaza = godinestaza;
        }

        public string Titula { get; set; }
        public int Godinestaza { get; set; }
        public List<Asistent> KolekcijaAsistenataKojiRadeZaNjega { get; set; }
        List<KeyValuePair<string, IspitniRok>> KolekcijaSvihPrijavljenihIspitaaa { get; set; }
        public List<Kolegij> KolekcijaKolegija { get; set; }





        public void DodajKolegij(Kolegij other)=>KolekcijaKolegija.Add(other);
        public void DodajAsistena(Asistent other)=>KolekcijaAsistenataKojiRadeZaNjega.Add(other);
        public void DodajUkolekciju(string s,IspitniRok i)=>KolekcijaSvihPrijavljenihIspitaaa.Add(new KeyValuePair<string, IspitniRok>(s, i));


        public void IspraviRok(IspitniRok i)=> i.ispravi();
        public override string ToString() => $"{base.ToString()}, Id: {id} , Titula: {Titula}, Godine staza: {Godinestaza}";
        public  void IspisSvihRokovaStudenata()
         {
                Console.WriteLine("Ispis svih studenata koju su prijavili rok: ");

                foreach(KeyValuePair < string,IspitniRok > item in KolekcijaSvihPrijavljenihIspitaaa)
                  {
                    Console.Write("JMBAG studenta: "+item.Key + "| Podaci o ispitnom roku: " + item.Value.ToString()+"\n");
                  }
         }  


    }
}