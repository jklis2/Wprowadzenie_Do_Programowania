using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1interaktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj!");
            Console.Write("Podaj swoje imię :");
            string imie; //deklaracja
            imie = Console.ReadLine(); //przypisanie

            Console.Write("Podaj swoje nazwisko :");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj, " + imie + " " + nazwisko + "!"); //sposób 1 - konkatenacja

            string napis = string.Format("Witaj, {0} {1}!", imie, nazwisko);//przygotowujemy wzorzec i bindujemy
            Console.WriteLine(napis);

            Console.WriteLine("Witaj, {0} {1}!", imie, nazwisko); //podajemy wzorzec i bindujemy

            Console.WriteLine($"Witaj, {imie} {nazwisko}!");

            Console.Write("Podaj swój wiek: ");

            string wiekTekstowo = Console.ReadLine();
            int wiek = int.Parse(wiekTekstowo);

            if (wiek > 65)
            {
                Console.WriteLine("Jesteś emerytem");
            }
            else
            {
                Console.WriteLine($"Do emerytury zostało Ci {65 - wiek} lat!");
            }






        }
    }
}