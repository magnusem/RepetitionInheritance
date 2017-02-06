using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
  public  class DieselBil : Bil
    {
        public bool PartikelFiler { get; set; }

        public override int HalvÅrligEjerAfgift()
        {
            if (PartikelFiler == true)
            {
                return base.HalvÅrligEjerAfgift();
            }
            else
            {
                return base.HalvÅrligEjerAfgift() + 500;
            }
        }




        public DieselBil(string mærke, double prisExAfgift, int købsÅr, int kmPrLiter, bool partikelfilter, string RegistreringsNr) : base(mærke, prisExAfgift, købsÅr, kmPrLiter, RegistreringsNr)
        {
            this.PartikelFiler = partikelfilter;
            this.RegistreringsNr = RegistreringsNr;
            this.RegistreringsAfgift();
        }

        public DieselBil(string mærke, double prisExAfgift, int købsÅr, int kmPrLiter, string RegistreringsNr) : this(mærke, prisExAfgift, købsÅr, kmPrLiter, true, RegistreringsNr)
        {
        }

    }
}
