using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    public class Bil
    {
        public int BilPrisExAfgift { get; private set; }
        public int KøbsÅr { get; private set; }
        public string Mærke { get; private set; }
        public string RegistreringsNr { get; set; }
        public int KmPrLiter { get; private set; }

        public virtual double RegistreringsAfgift()
        {
            double regAfgift;

            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift >= 80500)
                {
                    regAfgift = BilPrisExAfgift * 105 / 100;
                }
                else
                {
                    regAfgift = BilPrisExAfgift * 180 / 100;
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

        public virtual int HalvÅrligEjerAfgift()
        {
            return 1000;
        }

        public Bil(string Mærke, double prisExAfgift, int købsÅr, int kmPrLiter, string registreringsNr)
        {
            this.Mærke = Mærke;
            this.BilPrisExAfgift = BilPrisExAfgift;
            this.KøbsÅr = KøbsÅr;
            this.KmPrLiter = KmPrLiter;
            this.RegistreringsNr = RegistreringsNr;
            this.RegistreringsAfgift();
        }
    }
}
