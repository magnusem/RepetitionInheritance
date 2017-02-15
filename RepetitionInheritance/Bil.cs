using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    public abstract class Bil
    {
        public double BilPrisExAfgift { get; private set; }
        public int KøbsÅr { get; private set; }
        public string Mærke { get; private set; }
        public string RegistreringsNr { get; set; }
        public int KmPrLiter { get; private set; }
        public int Tank { get; set; }


        public virtual double RegistreringsAfgift()
        {
            double regAfgift;

            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift <= 80500)
                {
                    regAfgift = BilPrisExAfgift *1.05;
                }
                else
                {
                    regAfgift = BilPrisExAfgift * 1.8;
                }
                return regAfgift;
            }
            else
            {
                if (BilPrisExAfgift >= 81700)
                {
                    regAfgift = BilPrisExAfgift * 105 / 100;
                }
                else
                {
                    regAfgift = BilPrisExAfgift * 180 / 100;
                }

                return regAfgift;
            }
        }

        public double TotalPris()
        {
            return BilPrisExAfgift + RegistreringsAfgift();
        }

        public abstract int HalvÅrligEjerAfgift();


        public virtual int RækkeVidde()
        {
            return Tank * KmPrLiter;
        }



        public Bil(string Mærke, double prisExAfgift, int købsÅr, string registreringsNr, int tank)
        {
            this.Mærke = Mærke;
            this.BilPrisExAfgift = prisExAfgift;
            this.KøbsÅr = købsÅr;
            this.RegistreringsNr = registreringsNr;
            this.RegistreringsAfgift();
            this.Tank = tank;
        }


    }
}
