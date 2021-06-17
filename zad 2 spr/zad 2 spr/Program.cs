using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int LiczbaPodejsc { get; set; } = 0;
    public int WynikNajlepszy { get; set; } = 0;
    public int WynikNajgorszy { get; set; } = 0;
    public int WynikOstatni { get; set; } = 0;
    public double WynikSredni
    {
        get => wyniki.Count != 0 ? Math.Round((double)(wyniki.Sum(x => x) / (double)wyniki.Count), 1) : 0;
    }

    public string Ocena { get => GetOcena(); }

    private List<int> wyniki = new List<int>();

    private string login;
    private string haslo;

    public Student(string login, string haslo)
    {
        SetLogin(login);

        if (CzyHasloOk(haslo))
            this.haslo = haslo;
        else
            throw new ArgumentException("Blende haslo!");
    }

    public string Login { get => login; set => SetLogin(value); }
    private string Haslo { get => haslo; set => haslo = value; }

    public void ZarejestrujWynik(int wynik)
    {
        if (wynik < 0 || wynik > 100)
            throw new ArgumentOutOfRangeException("Zla wartosc!");

        wyniki.Add(wynik);
        LiczbaPodejsc++;

        if (wyniki.Count == 1)
        {
            WynikNajgorszy = wynik;
            WynikNajlepszy = wynik;
        }

        if (WynikNajgorszy > wynik)
            WynikNajgorszy = wynik;
        if (WynikNajlepszy < wynik)
            WynikNajlepszy = wynik;

        WynikOstatni = wynik;
    }

    public bool ProbujZarejestrowacWynik(int wynik)
    {
        if (wynik < 0 || wynik > 100)
            return false;

        wyniki.Add(wynik);
        LiczbaPodejsc++;

        if (wyniki.Count == 1)
        {
            WynikNajgorszy = wynik;
            WynikNajlepszy = wynik;
        }

        if (WynikNajgorszy > wynik)
            WynikNajgorszy = wynik;
        if (WynikNajlepszy < wynik)
            WynikNajlepszy = wynik;

        WynikOstatni = wynik;

        return true;
    }


    public bool ZmienHaslo(string stare, string nowe)
    {
        if (!PoprawneHaslo(stare))
            return false;
        if (!CzyHasloOk(nowe))
            return false;

        haslo = nowe;

        return true;
    }
    public bool PoprawneHaslo(string haslo)
    {
        return Haslo == haslo;
    }
    private bool CzyHasloOk(string haslo)
    {
        if (haslo == null)
            return false;

        foreach (char c in haslo)
        {
            if (!char.IsDigit(c))
                return false;
        }

        if (haslo.Length < 4 || haslo.Length > 8)
            return false;

        return true;
    }
    private void SetLogin(string value)
    {
        if (value == null)
            throw new ArgumentException("Bledny login!");

        value = value.Replace(" ", "");
        value = value.ToLower();

        if (!char.IsLetter(value[0]))
            throw new ArgumentException("Bledny login!");

        if (value.Length < 4)
            throw new ArgumentException("Bledny login!");

        foreach (char c in value)
        {
            if (!char.IsLetterOrDigit(c))
            {
                throw new ArgumentException("Bledny login!");
            }
        }
        login = value;
    }
    private string GetOcena()
    {
        if (WynikNajlepszy < 40)
        {
            return "niedostateczny";
        }
        else if (WynikNajlepszy < 50)
        {
            return "dostateczny";
        }
        else if (WynikNajlepszy < 60)
        {
            return "dostateczny plus";
        }
        else if (WynikNajlepszy < 70)
        {
            return "dobry";
        }
        else if (WynikNajlepszy < 80)
        {
            return "dobry plus";
        }
        else
        {
            return "bardzo dobry";
        }
    }

    public override string ToString()
    {
        return $"Login: {Login}. Wyniki: n={LiczbaPodejsc}, ostatni={WynikOstatni}, najlepszy={WynikNajlepszy}, najgorszy={WynikNajgorszy}, sredni={WynikSredni}";
    }
}