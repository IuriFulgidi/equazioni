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

        public static bool IsIncosnsisteded(double a, double b)
        {
            bool ris = true;

            if (a != 0 || b != 0)
                ris = false;

            return ris;
        }

        public static bool IsImpossible(double a, double b)
        {
            bool ris = false;

            if (a == 0 && b != 0)
                ris = true;

            return ris;
        }
    }
}