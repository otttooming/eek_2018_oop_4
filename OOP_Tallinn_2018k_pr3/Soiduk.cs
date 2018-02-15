using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tallinn_2018k_pr3
{
    abstract class Soiduk : Utiliit, IComparable<Soiduk>
    {
        protected int va; // väljalaske aasta  
        public string regNr { get; set; }
        protected double kaal;
        protected double alghind;

        public int tagastaVa() { return va; }
        public double tagastaKaal() { return kaal; }

        public Soiduk(int va = 0, string regNr = "--", double kaal = 0, double alghind=0)
        {
            this.va = va;
            this.regNr = regNr;
            this.kaal = kaal;
            this.alghind = alghind;
        }

        public Soiduk(Soiduk s)
        {
            this.va = s.va;
            this.regNr = s.regNr;
            this.kaal = s.kaal;
            this.alghind = s.alghind;
        }

        public virtual void tryki()
        {
            Console.Write("{0,4} {1,10} {2,9:f1} {3,9:f2}", va, regNr, kaal, alghind);
        }

        public int arvutaVanus()
        {
            DateTime tana = DateTime.Now;
            int vanus = tana.Year - va;
            return vanus;
        }

        public abstract void soiduKeskkond();

        public abstract double arvutaHetkeHind();

        public int CompareTo(Soiduk s)
        {
            if (this.arvutaHetkeHind() < s.arvutaHetkeHind())
            {
                return 1;
            }
            else if (this.arvutaHetkeHind() == s.arvutaHetkeHind())
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
