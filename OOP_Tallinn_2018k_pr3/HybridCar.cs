using System;
namespace OOP_Tallinn_2018k_pr3
{
    class HybridCar : Auto
    {
        protected double L100; // L per 100 km
        protected int paagiMaht;
        protected int akuMaht; // kwh
        protected double km_kwh;

        public HybridCar(int va = 0, string regNr = "--", double kaal = 0, double alghind = 0,
            int istekohti = 0, string veotyyp = "---", double L100 = 0, int paagiMaht = 0, int akuMaht = 0, double km_kwh = 0)
            :base(va,regNr, kaal, alghind, istekohti, veotyyp)
        {
            this.L100 = L100;  this.paagiMaht = paagiMaht;
            this.akuMaht = akuMaht; this.km_kwh = km_kwh;
        }

        public HybridCar(HybridCar ob) : base(ob) {
            this.L100 = ob.L100; this.paagiMaht = ob.paagiMaht;
            this.akuMaht = ob.akuMaht; this.km_kwh = ob.km_kwh; 
        }

        public override double arvutaKytuseKulu()
        {
            return (100 / L100) * paagiMaht + akuMaht * km_kwh;
        }

        public override void tryki()
        {
            base.tryki();
            Console.Write(" {0,4:f1} {1,3} {2,3} {3,3:f1}", L100, paagiMaht, akuMaht, km_kwh);
        }
    }
}
