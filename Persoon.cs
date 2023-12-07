using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blok3Les6
{
    public class Persoon
    {
        public string Voornaam { get; set; }


        //Constructor met 1 parameter

        public Persoon(string Voornaam)
        {
            this.Voornaam = Voornaam;
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Hallo ik ben {this.Voornaam}");
        }

        public void VraagInfo()
        {
            Console.WriteLine("Geef een naam:");
            this.Voornaam = Console.ReadLine();
        }


    }


}
