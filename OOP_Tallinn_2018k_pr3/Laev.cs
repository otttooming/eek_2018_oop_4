using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tallinn_2018k_pr3
{
    class Laev : Soiduk
    {
        protected int veeValjaSurve;
        protected string tyyp;

        public Laev(int va = 0, string regNr = "--", double kaal = 0,
            double alghind = 0, int veeValjaSurve = 0, string tyyp = "---")
            :base(va,regNr,kaal,alghind)
        {
            this.veeValjaSurve = veeValjaSurve;
            this.tyyp = tyyp;
        }

        public Laev(Laev ob)
            : base(ob)
        {
            this.veeValjaSurve = ob.veeValjaSurve;
            this.tyyp = ob.tyyp;
        }

        public override void soiduKeskkond()
        {
            Console.WriteLine("Laev soidab vees");
        }

        public override double arvutaHetkeHind()
        {
            int vanus = arvutaVanus();
            double uushind = alghind;
            for (int i = 1; i <= vanus; i++)
            {
                if (i <= 15)
                    uushind *= 0.91;
                else
                    uushind *= 0.88;
            }
            return uushind;
        }

        public override void tryki()
        {
            base.tryki();
            Console.Write(" {0,3} {1,-10}",veeValjaSurve,tyyp);
        }



    }
}
