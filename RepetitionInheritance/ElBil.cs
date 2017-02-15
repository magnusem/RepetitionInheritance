using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    public class ElBil : Bil
    {
        public int BatteriKapacitet { get; set; }
        public int KmPrKW { get; set; }
        public ElBil(string Mærke, double prisExAfgift, int købsÅr, string registreringsNr, int tank, int kmPrKW) : base(Mærke, prisExAfgift, købsÅr, registreringsNr, tank)
        {
        }

        public override int HalvÅrligEjerAfgift()
        {
            return 0;
        }

        public override double RegistreringsAfgift()
        {
            return base.RegistreringsAfgift() * 0.20;
        }

        public override int RækkeVidde()
        {
            return BatteriKapacitet / KmPrKW;
        }

    }
}
