using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
  public sealed class DieselBil : Bil
    {
        public bool PartikelFilter { get; set; }

        public override int HalvÅrligEjerAfgift()
        {
            if (PartikelFilter == true)
            {
                if (KmPrLiter < 15)
                {
                    return 2000 + 500;
                }
                else if (KmPrLiter >= 15 && KmPrLiter <= 25 )
                {
                    return 1000 + 500;
                }
                else
                {
                    return 350 + 500;
                }
            }
            else
            {
                if (KmPrLiter < 15)
                {
                    return 2000;
                }
                else if (KmPrLiter >= 15 && KmPrLiter <= 25)
                {
                    return 1000;
                }
                else
                {
                    return 350;
                }
            }
        }



        public DieselBil(string mærke, double prisExAfgift, int købsÅr, int kmPrLiter, bool partikelfilter, string RegistreringsNr, int tank) : base(mærke, prisExAfgift, købsÅr, RegistreringsNr, tank)
        {
            this.PartikelFilter = partikelfilter;
            this.RegistreringsNr = RegistreringsNr;
            this.RegistreringsAfgift();
        }

        public DieselBil(string mærke, double prisExAfgift, int købsÅr, int kmPrLiter, string RegistreringsNr, int tank) : this(mærke, prisExAfgift, købsÅr, kmPrLiter, true, RegistreringsNr, tank)
        {
        }

        public override int RækkeVidde()
        {
            return base.RækkeVidde();
        }


    }
}
