using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tallinn_2018k_pr3
{
    class Auto : Soiduk
    {
        protected int istekohti;
        protected string veotyyp;   // esivedu, tagavedu, nelikvedu

        public Auto(int va = 0, string regNr = "--", double kaal = 0, double alghind=0,
            int istekohti = 0, string veotyyp = "---")
            : base(va, regNr, kaal, alghind)
        { this.istekohti = istekohti; this.veotyyp = veotyyp;      }

        public Auto(Auto ob) : base(ob)
        { this.istekohti = ob.istekohti; this.veotyyp = ob.veotyyp; }

        public override void soiduKeskkond() { Console.WriteLine("Auto soidab maal"); }

        public override void tryki()
        {
            base.tryki();
            Console.Write(" {0,3} {1,-10}", istekohti, veotyyp);
        }

        public virtual double arvutaKytuseKulu() { return 0; }

        public override double arvutaHetkeHind()
        {
            int vanus = arvutaVanus();
            double uushind = alghind;
            for (int i = 1; i <= vanus; i++)
                uushind *= 0.84;
            return uushind;
        }

    }
}
