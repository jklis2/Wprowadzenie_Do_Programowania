using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM003Z01___Czas24h
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] napis = null;
            Czas24h t = null;
            napis = Console.ReadLine().Split(':');
            int[] czas = Array.ConvertAll(napis, int.Parse);
            try
            {
                t = new Czas24h(czas[0], czas[1], czas[2]);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("error");
                return;
            }
            int liczbaPolecen = int.Parse(Console.ReadLine());
            for (int i = 1; i <= liczbaPolecen; i++)
            {
                napis = Console.ReadLine().Split(' ');
                string typPolecenia = napis[0];
                int liczba = int.Parse(napis[1]);
                try
                {
                    switch (typPolecenia)
                    {
                        case "g":
                            t.Godzina = liczba;
                            break;
                        case "m":
                            t.Minuta = liczba;
                            break;
                        case "s":
                            t.Sekunda = liczba;
                            break;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            Console.WriteLine(t);
        }
    }
    public class Czas24h
    {
        private int liczbaSekund;

        public int Sekunda
        {
            get => liczbaSekund - Godzina * 60 * 60 - Minuta * 60;
            set
            {
                if (value >= 0 && value <= 59)
                {
                    liczbaSekund -= Sekunda - value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public int Minuta
        {
            get => (liczbaSekund / 60) % 60;
            set
            {
                if (value >= 0 && value <= 59)
                {
                    liczbaSekund -= (Minuta - value) * 60;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public int Godzina
        {
            get => liczbaSekund / 3600;

            set
            {
                if (value >= 0 && value <= 23)
                {
                    liczbaSekund -= (Godzina - value) * 3600;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Czas24h(int godzina, int minuta, int sekunda)
        {

            if ((godzina >= 0 && godzina <= 23) && (minuta >= 0 && minuta <= 59) && (sekunda >= 0 && sekunda <= 59))
            {
                liczbaSekund = sekunda + 60 * minuta + 3600 * godzina;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public override string ToString() => $"{Godzina}:{Minuta:D2}:{Sekunda:D2}";
    }
}
