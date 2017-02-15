using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning
{
    
    /// <summary>
    /// DiselBil object
    /// </summary>
    public class Dieselbil : Bil
    {
        public bool PartikelFilter { get; set; }
        //public int KmPrLiter { get; set; }

        /// <summary>
        /// angiver tanken i liter
        /// </summary>
        public int Tank { get; private  set; }
        public int KmPrLiter { get; private set; }

        public Dieselbil(int pris, int købsår, string mærke, string regnr, int kmLiter, int tank)
           :this(pris, købsår, mærke, regnr, kmLiter, tank, true)
        {
        }

        public Dieselbil(int pris,int købsår,string mærke,string regnr, int kmLiter, int tank, bool partikelFilter)
            :base(pris,købsår,mærke,regnr)
        {
            this.PartikelFilter = partikelFilter;
            this.Tank = tank;
            this.KmPrLiter = kmLiter;
        }

        /// <summary>
        /// Halvårlig ejerafgift for dieselbil
        /// </summary>
        /// <returns></returns>
        public override int HalvÅrligEjerAfgift()
        {
            int afgift = 0;

            if (!PartikelFilter)
                afgift = 500;

            if (this.KmPrLiter < 15)
                return afgift+2000;
            else if (this.KmPrLiter > 25)
                return afgift+350;
            else
               return afgift+1000;
        }

        /// <summary>
        /// rækkevidden for dieselbilen
        /// </summary>
        /// <returns></returns>
        public override int RækkeVidde()
        {
            return Tank*KmPrLiter;
        }

        public override string ToString()
        {
            return $"{this.BilMærke} - {this.RegisteringsnrNr} - pris ex. afgift {this.BilPrisExAfgift} - Totalpris {this.TotalPris()}- km/l:{this.KmPrLiter} -rækkevidde: {this.RækkeVidde()} ";

        }
    }
}
