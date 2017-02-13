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
            //List<DieselBil> DBilListe = new List<DieselBil>();
            //List<BenzinBil> BBilListe = new List<BenzinBil>();
            //List<ElBil> EBilListe = new List<ElBil>();

            List<Bil> BilListe = new List<Bil>();
            BilListe.Add(new DieselBil("VW", 200000, 2010, 16, false, "12345678", 30));
            BilListe.Add(new BenzinBil("Honda", 10000, 1999, 11, "PANDA", 65));
            BilListe.Add(new ElBil("Tesla4", 1000000, 2017, "AY81344", 60, 10));

            foreach (Bil Bil in BilListe)
            {
                if (Bil is ElBil)
                {
                    ElBil minBil = Bil as ElBil;

                    Console.WriteLine(minBil.BilPrisExAfgift);
                    Console.WriteLine(minBil.KmPrLiter);
                    Console.WriteLine(minBil.KøbsÅr);
                    Console.WriteLine(minBil.Mærke);
                    Console.WriteLine(minBil.HalvÅrligEjerAfgift());
                    Console.WriteLine(minBil.RegistreringsAfgift());
                    //Console.WriteLine(minBil.RækkeVidde());
                    Console.WriteLine(minBil.KmPrKW);
                }
                else if (true)
                {

                }
            }



            //DBilListe.Add(new DieselBil("VW", 200000, 2010, 16, false, "12345678", 30));
            //DBilListe.Add(new DieselBil("Audi", 50000, 2016, 25, false, "23456789", 20));
            //DBilListe.Add(new DieselBil("Volvo", 90000, 2005, 13, true, "34567890", 40));
            //DBilListe.Add(new DieselBil("Toyota", 75000, 1999, 10, true, "45678901", 65));

            //BBilListe.Add(new BenzinBil("Honda", 10000, 1999, 11, "PANDA", 65));
            //BBilListe.Add(new BenzinBil("Fiat Multiblyat", 19000, 2016, 9, "DBHA72", 35));
            //BBilListe.Add(new BenzinBil("Suzuki", 40000, 2002, 15, "JNAB823", 25));
            //BBilListe.Add(new BenzinBil("Mercedes", 300000, 2014, 27, "XLAS321", 50));

            //EBilListe.Add(new ElBil("Tesla", 849000, 2016, "AY81341", 30, 30));
            //EBilListe.Add(new ElBil("Tesla2", 950000, 2017, "AY81342", 40, 35));
            //EBilListe.Add(new ElBil("Tesla3", 449000, 2016, "AY81343", 50, 70));
            //EBilListe.Add(new ElBil("Tesla4", 1000000, 2017, "AY81344", 60, 10));





            //foreach (var db in DBilListe)
            //{
            //    Console.WriteLine("Halvårlig: " + db.HalvÅrligEjerAfgift());
            //    Console.WriteLine("Mærke: " + db.Mærke);
            //    Console.WriteLine("KøbsÅr: " + db.KøbsÅr);
            //    Console.WriteLine("KmPrLiter: " + db.KmPrLiter);
            //    Console.WriteLine("RegistreringsNr: " + db.RegistreringsNr);
            //    Console.WriteLine("RækkeVidde: " + db.RækkeVidde());
            //}

            //    foreach (var bb in BBilListe)
            //    {
            //        Console.WriteLine("Halvårlig: " + bb.HalvÅrligEjerAfgift());
            //        Console.WriteLine("Mærke: " + bb.Mærke);
            //        Console.WriteLine("KøbsÅr: " + bb.KøbsÅr);
            //        Console.WriteLine("KmPrLiter: " + bb.KmPrLiter);
            //        Console.WriteLine("RegistreringsNr: " + bb.RegistreringsNr);
            //        Console.WriteLine("RækkeVidde: " + bb.RækkeVidde());
            //    }
            //}
        }
    }
}

