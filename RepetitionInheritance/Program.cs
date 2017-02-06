using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DieselBil> BilListe = new List<DieselBil>();

            BilListe.Add(new DieselBil("VW", 200000, 2010, 16, false, "12345678"));
            BilListe.Add(new DieselBil("Audi", 50000, 2016, 25, "23456789"));
            BilListe.Add(new DieselBil("Volvo", 90000, 2005, 13, "34567890"));
            BilListe.Add(new DieselBil("Toyota", 75000, 1999, 10, "45678901"));


            foreach (var db in BilListe)
            {
                Console.WriteLine(db.HalvÅrligEjerAfgift());
                Console.WriteLine(db.RegistreringsNr);
            }
        }
    }
}
