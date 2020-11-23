using System;

namespace Ishodi2i3
{
    class Program
    {
        static void Main(string[] args)
        {

            //napravio sam par studenata,profesora,asistenata,kolegija,ispitnih rokava te kontinuiranu provjeru
            Student s1 = new Student("Josko", "Boric", "1111111111", 2);
            Student s2 = new Student("Mario", "Antelic", "2222222222", 2);

            Profesor p1 = new Profesor("Marija", "Maric", "BiG", 233);
            Profesor p2 = new Profesor("Dusko", "Dorijanovic", "NiC", 31);

            Asistent a1 = new Asistent("Morio", "Morenovic", "XdE", 2);
            Asistent a2 = new Asistent("Baniel", "Dele", "B0G", 999);

            Kolegij k1 = new Kolegij("Vjerojatnost i statistika", 5, p1);
            Kolegij k2 = new Kolegij("Operacijski sustavi", 4, p2);

            IspitniRok i1 = new IspitniRok("21.12.2020 9:00", k1);
            IspitniRok i2 = new IspitniRok("24.11.2020 19:00", k2);

            KontinuiranaProvjera ko1 = new KontinuiranaProvjera(k2);


            Console.WriteLine("PRIJAVLJENI ROKOVI:" );
            //student prijavljuje rok
            s1.PrijaviRok(i1);
            s1.PrijaviRok(i2);
            s1.IspisPrijavljenihRokova();
            //student odjavljuje rok unosom ID-a roka kojeg je prijavio
            s1.OdjaviRok(2);
            Console.WriteLine("PRIJAVLJENI ROKOVI NAKON ODJAVJE :");
            s1.IspisPrijavljenihRokova();
            Console.WriteLine("PODACI O STUDENTU: ");
            Console.WriteLine(s1.ToString());



            //dodajemo asistenta koji radi za određenog profesora
            p1.DodajAsistena(a2);
            //dodajemo kolegij kojeg profesor predaje profesoru
            p1.DodajKolegij(k1);
            //ispis svih rokova studenata
            p1.IspisSvihRokovaStudenata();
            Console.WriteLine("Podaci o profesoru");
            Console.WriteLine(p1.ToString());
            //profesor moze ispraviti rok no ne i provjeru
            Console.WriteLine("Nakon ispravljanja roka");
            p1.IspraviRok(i1);
            Console.WriteLine(i1.ToString());




            //dodajemo profesora za kojeg radi asistent
            a1.DodajProfesoraZaKojegRadi(p1);
            //moze ispraviti i rok i provjeru
            a1.IspraviRok(i1);
            a1.IspravProvjeruk(ko1);

        }
    }
}
