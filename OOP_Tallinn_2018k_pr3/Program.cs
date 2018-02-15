using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tallinn_2018k_pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Honda = new Auto(2004, "306ATR", 1400, 22000, 5, "Esivedu");
            Honda.tryki();
            Console.WriteLine();
            double h = Honda.arvutaHetkeHind();
            Console.WriteLine("Praeguseks hinnaks on: {0,10:f2}",h);


            Auto Audi = new Auto(2007, "535VFD", 2400, 77000, 5, "Nelikvedu");
            Audi.tryki();
            Console.WriteLine();

            Auto BMW = new Auto(2010, "234VFD", 2100, 54000, 5, "Tagavedu");
            Audi.tryki();
            Console.WriteLine();

            Laev MegaStaar = new Laev(2015,"JHGDGYH23",263,23.31,650,"ReisiLaev");
            MegaStaar.tryki();
            Console.WriteLine();

            Laev SuperStaar = new Laev(2012, "IUYTYH23", 232, 21.31, 550, "ReisiLaev");
            MegaStaar.tryki();
            Console.WriteLine();

            Lennuk Bowing = new Lennuk(2010, "RETYH23", 72, 28.31, 11, 4);
            Bowing.tryki();
            Console.WriteLine();

            Lennuk AirBus = new Lennuk(2011, "ADSYH23", 65, 33.31, 12, 6);
            AirBus.tryki();
            Console.WriteLine();

            List<Soiduk> DHL_soidukid = new List<Soiduk>();
            DHL_soidukid.Add(Honda);
            DHL_soidukid.Add(BMW);
            DHL_soidukid.Add(MegaStaar);
            DHL_soidukid.Add(Bowing);
            DHL_soidukid.Add(Audi);
            DHL_soidukid.Add(AirBus);
            DHL_soidukid.Insert(2,SuperStaar);

            Console.WriteLine("\n DHL soidukite andmed:\n");

            foreach(Soiduk x in DHL_soidukid)
            {
                x.tryki();
                x.soiduKeskkond();
             //   x.arvutaHetkeHind() 
            }

            Console.WriteLine("\n DHL soidukite praegused hinnad:\n");

            foreach (Soiduk x in DHL_soidukid)
            {
                x.tryki();
                Console.Write("  {0,9:f2}", x.arvutaHetkeHind());
                if (x is Auto)
                    Console.WriteLine(" EUR");
                else
                    Console.WriteLine(" Milj EUR");

            }



            Console.Read();
        }
    }
}
