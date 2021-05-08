using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_Trojkat
{
    class Klasa_Trojkat
    {
        public const int PRECYZJA = 4;
        // Dane
        public double A { get; private set; }

        public double B { get; private set; }

        public double C { get; private set; }

        // Konstruktory
        public Klasa_Trojkat()
        {
            A = B = C = 1.0;
        }

        public Klasa_Trojkat(double a, double b, double c)
        {
            a = Math.Round(a, PRECYZJA);
            b = Math.Round(b, PRECYZJA);
            c = Math.Round(c, PRECYZJA);

            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Długości nie mogą być ujemne");
            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("Nie spełnipny warunek trójkąta");
            A = a;
            B = b;
            C = c;
        }
        // To String
        public override string ToString()
        {
            return $"Trojkat (a={A}, b={B}, c={C})";
        }
        // Inne metody
        public double ObliczObwod()
        {
            return Math.Round(A + B + C, PRECYZJA);
        }

        public double Obwod => Math.Round(A + B + C, PRECYZJA);
    }
}
