using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tallinn_2018k_pr3
{
    class SoidukRegNrJargi : IComparer<Soiduk>
    {
        public int Compare(Soiduk a, Soiduk b)
        {
            return string.Compare(a.regNr, b.regNr);
        }
    }
}
