using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    public class BenzinBil : Bil
    {
        public BenzinBil(string Mærke, double prisExAfgift, int købsÅr, int kmPrLiter, string registreringsNr, int tank) : base(Mærke, prisExAfgift, købsÅr, registreringsNr, tank)
        {

        }


        public override int RækkeVidde()
        {
            return base.RækkeVidde();
        }

        public override int HalvÅrligEjerAfgift()
        {
            if (KmPrLiter < 20)
            {
                return 1200;
            }
            else if (KmPrLiter >= 20 && KmPrLiter <= 28)
            {
                return 600;
            }
            else
            {
                return 320;
            }
        }

    }
}
