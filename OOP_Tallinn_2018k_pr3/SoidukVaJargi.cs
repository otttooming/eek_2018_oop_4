using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tallinn_2018k_pr3
{
    class SoidukVaJargi : IComparer<Soiduk>
    {
        public int Compare(Soiduk a, Soiduk b)
        {
            if (a.tagastaVa() < b.tagastaVa())
                return 1;
            else if (a.tagastaVa() == b.tagastaVa())
                return 0;
            else
                return -1;
        }
    }
}
