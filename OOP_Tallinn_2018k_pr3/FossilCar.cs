using System;
namespace OOP_Tallinn_2018k_pr3
{
    class FossilCar : Auto
    {
        protected double L100; // L per 100 km
        protected int paagiMaht;

        public FossilCar(int va = 0, string regNr = "--", double kaal = 0, double alghind = 0,
            int istekohti = 0, string veotyyp = "---", double L100 = 0, int paagiMaht = 0)
            :base(va,regNr, kaal, alghind, istekohti, veotyyp)
        {
            this.L100 = L100; this.paagiMaht = paagiMaht;
        }

        public FossilCar(FossilCar ob) : base(ob) { this.L100 = ob.L100; this.paagiMaht = ob.paagiMaht; }

        public override void tryki()
        {
            base.tryki();
            Console.Write(" {0,4:f1} {1,3}",L100,paagiMaht);
        }

        public override double arvutaKytuseKulu() { 
            return (100/L100) * paagiMaht; 
        }
    }
}
