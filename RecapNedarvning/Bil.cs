using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning
{
    public abstract class Bil : IBil
    {
        public int BilPrisExAfgift { get; private set; }
        public int KøbsÅr { get; private set; }
        public string BilMærke { get; set; }
        public string RegisteringsnrNr { get; set; }
        //public int KmPrLiter { get; set; }


        protected Bil(int pris, int købsår, string mærke, string regnr)
        {
            this.BilPrisExAfgift = pris;
            this.KøbsÅr = købsår;
            this.BilMærke = mærke;
            this.RegisteringsnrNr = regnr;
            //this.KmPrLiter = KmPrL;
        }

        /// <summary>
        /// viser rækkevidden for bilen 
        /// </summary>
        /// <returns></returns>
        public abstract int RækkeVidde();

        /// <summary>
        /// beregner registreringsafgiften for bilen
        /// </summary>
        /// <returns></returns>
        public virtual int Registreringsafgift()
        {
            int pct105afgift2014 = 80500;
            int pct105afgift2015 = 81700;

            if (KøbsÅr <= 2015)
            {
              return  beregnAfgift(pct105afgift2014);
            }
            else
            {
               return beregnAfgift(pct105afgift2015);
            }
        }

        /// <summary>
        /// beregner lav og høj afgift
        /// </summary>
        /// <param name="minimumafgift"> lav regafgift</param>
        /// <param name="pris">prisen på bilen uden regafgift</param>
        /// <returns></returns>
        private int beregnAfgift(int minimumafgift)
        {
            if (this.BilPrisExAfgift <= 0)
                return 0;

            if (this.BilPrisExAfgift <= minimumafgift)
                return BilPrisExAfgift*105/100;

            int pct105 = 0;
            int pct180 = 0;

            pct105 = minimumafgift;
            pct180 = (this.BilPrisExAfgift - minimumafgift)*180/100;
            return (pct105*105/100) + pct180;

        }

        /// <summary>
        /// giver bilens totalpris dvs. pris inkl afgift
        /// </summary>
        /// <returns></returns>
        public int TotalPris()
        {
            return this.BilPrisExAfgift + this.Registreringsafgift();
        }

        public abstract int HalvÅrligEjerAfgift();

//Personbiler  105 % af værdien op til 81.700 kr.og 180 % af resten
    }
}
