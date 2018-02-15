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


            // NEw material

            FossilCar Ford1 = new FossilCar(2005, "987ABC", 1000, 21000, 5, "Esivedu", 7.5, 100);
            FossilCar Ford2 = new FossilCar(Ford1);
            Ford2.regNr = "777OKT";

            ElectricCar TeslaModelS1 = new ElectricCar(2017, "CAL999", 2300, 100000, 4, "Esivedu", 85, 3.9);
            ElectricCar TeslaModelS2 = new ElectricCar(TeslaModelS1);
            TeslaModelS2.regNr = "DEL111";

            HybridCar Prius1 = new HybridCar(2018, "345TRI", 1.5, 50000, 5, "Esivedu", 4.5, 40, 8, 4.2);
            HybridCar ChevyVolt = new HybridCar(2017, "347REX", 1.5, 75000, 4, "Tagavedu", 4.3, 22, 8, 3.8);

            List<Auto> AutodParklas = new List<Auto>();
            AutodParklas.Add(Ford1);
            AutodParklas.Add(Prius1);
            AutodParklas.Add(TeslaModelS1);
            AutodParklas.Add(TeslaModelS2);
            AutodParklas.Add(ChevyVolt);
            AutodParklas.Add(Ford2);
            AutodParklas.Insert(4, new ElectricCar(2017, "HAL999", 2340, 980000, 3, "Esivedu", 95, 5.2));

            Console.WriteLine("\n carpark");
            foreach (Auto x in AutodParklas)
            {
                x.tryki();
                double su = x.arvutaKytuseKulu();

                Console.WriteLine(" {0,6:f1}", su);
            }


            Console.WriteLine("\n sorting");

            AutodParklas.Sort();
            foreach (Auto x in AutodParklas)
            {
                x.tryki();

                Console.WriteLine(" {}");
            }


            Console.Read();
        }
    }
}
