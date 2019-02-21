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
            if (a == 0)
                return false;

            return true;
        }

        public static bool IsNotDeterminated(double a, double b)
        {
            if (a != 0 || b != 0)
                return false;

            return true;
        }

        public static bool IsImpossible(double a, double b)
        {
            if (a == 0 && b != 0)
                return true;

            return false;
        }

        public static bool IsDegree2(double a)
        {
            if (a==0)
                return false;
            return true;
        }

        public static double Delta(double a, double b, double c)
        {
            return (b*b)-(4*(a*c));
        }

        public static string EquationDegree2(double a, double b, double c)
        {
            string ris = "";

            if (Equazioni.IsNotDeterminated(a, b))
                ris = "Indeterminato";

            else if (Equazioni.IsImpossible(a, b))
                ris = "Impossibile";

            else if (Equazioni.Delta(a, b, c) < 0)
                ris = "Impossibile";

            else if (Equazioni.Delta(a, b, c) == 0)
                ris = Convert.ToString(-b / (2 * a));

            else
            {
                double x = (-b + Math.Sqrt(Equazioni.Delta(a, b, c)))/ (2 * a);
                double y = (-b - Math.Sqrt(  Equazioni.Delta(a, b, c))) / (2 * a);
                ris = $"{x.ToString()} e {y.ToString()}";
            }

            return ris;
        }

        public static string EquationDegree1(double a, double b)
        {
            if (Equazioni.IsNotDeterminated(a, b))
                return "Indeterminato";

            else if (Equazioni.IsImpossible(a, b))
                return "Impossibile";
            else
            return Convert.ToString(-b / a);
        }
    }
}