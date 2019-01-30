using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public static class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool ris = true;

            if (a == 0)
                ris = false;

            return ris;
        }
    }
}