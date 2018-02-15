using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tallinn_2018k_pr3
{
    class Lennuk : Soiduk
    {
        protected int maxKorgus;
        protected int mootoriteArv;

        public Lennuk(int va = 0, string regNr = "--", double kaal = 0,
            double alghind = 0, int maxKorgus = 0, int mootoriteArv = 0)
            : base(va, regNr, kaal, alghind)
        {
            this.maxKorgus = maxKorgus;
            this.mootoriteArv = mootoriteArv;
        }

        public override void soiduKeskkond()
        {
            Console.WriteLine("Lennuk soidab ohus");
        }

        public override double arvutaHetkeHind()
        {
            int vanus = arvutaVanus();
            double uushind = alghind;
            for (int i = 1; i <= vanus; i++)
            {
                if (i <= 15)
                    uushind *= 0.9;
                else
                    uushind *= 0.84;
            }
            return uushind;
        }

        public override void tryki()
        {
            base.tryki();
            Console.Write(" {0,3} {1,8:f1}  ", mootoriteArv, maxKorgus);
        }

    }
}
