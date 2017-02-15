using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning
{
    /// <summary>
    /// Benzinbil
    /// </summary>
    public class BenzinBil : Bil
    {

        /// <summary>
        /// angiver tanken i liter
        /// </summary>
        public int Tank { get; private set; }
        public int KmPrLiter { get; set; }
           

        /// <summary>
        /// konstruktor for Benzinbil
        /// </summary>
        /// <param name="pris"></param>
        /// <param name="købsår"></param>
        /// <param name="kmPrL"></param>
        public BenzinBil(int pris, int købsår, string mærke, string regnr, int kmLiter, int tank)
            :base(pris, købsår, mærke, regnr)
        {
            this.KmPrLiter = kmLiter;
            this.Tank = tank;
        }


        public override int RækkeVidde()
        {
            return Tank*KmPrLiter;
        }

        /// <summary>
        /// Halvårlig ejerafgift for Benzinbil
        /// </summary>
        /// <returns></returns>
        public override int HalvÅrligEjerAfgift()
        {
            if (this.KmPrLiter < 20)
                return 1200;
            else if (this.KmPrLiter > 28)
                return 320;
            else
                return 600;
        }

        public override string ToString()
        {
            return $"{this.BilMærke} - {this.RegisteringsnrNr} - pris ex. afgift {this.BilPrisExAfgift} - Totalpris {this.TotalPris()}- km/l:{this.KmPrLiter} -rækkevidde: {this.RækkeVidde()} ";
        }
    }
}
