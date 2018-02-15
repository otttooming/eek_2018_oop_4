using System;
namespace OOP_Tallinn_2018k_pr3
{
    class ElectricCar : Auto
    {
        protected int akuMaht; // kwh
        protected double km_kwh;

        public ElectricCar(int va = 0, string regNr = "--", double kaal = 0, double alghind = 0,
            int istekohti = 0, string veotyyp = "---", int akuMaht = 0, double km_kwh = 0)
            :base(va,regNr, kaal, alghind, istekohti, veotyyp)
        {
            this.akuMaht = akuMaht; this.km_kwh = km_kwh;
        }

        public ElectricCar(ElectricCar ob) : base(ob) { this.akuMaht = ob.akuMaht; this.km_kwh = ob.km_kwh; }

        new public virtual void tryki()
        {
            base.tryki();
            Console.Write(" {0,3} {1,3:f1}", akuMaht, km_kwh);
        }

        public override double arvutaKytuseKulu() { 
            return akuMaht / km_kwh; 
        }
    }
}
