using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tallinn_2018k_pr3
{
    class SoidukKaaluJargi : IComparer<Soiduk>
    {
        public int Compare(Soiduk a, Soiduk b)
        {
            double ak = a.tagastaKaal();
            if (a is Laev || a is Lennuk)
            {
                ak = ak * 1000;
            }

            double bk = b.tagastaKaal();
            if (b is Laev || b is Lennuk)
            {
                bk = bk * 1000;
            }
            
            if (ak < bk)
                return 1;
            else if (ak == bk)
                return 0;
            else
                return -1;
        }
    }
}
