using System;

namespace W92MEN_SZTF1HF0011
{
    class Program
    {
        static void kotojelfeltoltes(string szoveg, int Min, int Max)
        {
            
            char[] vegKimenet = new char[(Max - Min) + 1];
            if (szoveg.Length >= Max)
            {
                for (int i = 0; i < vegKimenet.Length; i++)
                {
                    vegKimenet[i] = szoveg[Min - 1];
                    Min++;
                    Console.Write(vegKimenet[i]);
                }
            }
            else if (szoveg.Length < Max && szoveg.Length > Min)
            {
                int MinFix = Min;
                for (int i = 0; i < szoveg.Length - MinFix + 1; i++)
                {
                    vegKimenet[i] = szoveg[Min - 1];
                    Min++;
                    Console.Write(vegKimenet[i]);
                }
                for (int i = szoveg.Length; i < Max; i++)
                {
                    vegKimenet[i-MinFix] = '-';
                    Console.Write(vegKimenet[i-MinFix]);
                }
            }
            else if (szoveg.Length < Min)
            {
                for (int i = 0; i < vegKimenet.Length; i++)
                {
                    vegKimenet[i] = '-';
                    Console.Write(vegKimenet[i]);
                }
            }
        }
        static void Feldolgozo(string S, string P, int N, int Min, int Max)
        {
            string temp = "";
            if (P.Contains('$') && N > 0 && S.Length < Max)
            {
                N--;
                temp = P.Replace("$", S);
                S = temp;
                Feldolgozo(S,P,N,Min,Max);
            }
            if (!P.Contains('$'))
            {
                kotojelfeltoltes(P, Min, Max);
            }
            else
            {
                //Console.WriteLine(S);
                kotojelfeltoltes(S, Min, Max);
            }
        }

        static void Main(string[] args)
        {
            string behelyettesitendoKarakterek = Console.ReadLine();
            string amibeBeKellHelyettesiteni = Console.ReadLine();
            int ismetlesSzam = int.Parse(Console.ReadLine());
            int minimumErtek = int.Parse(Console.ReadLine());
            int maximumertek = int.Parse(Console.ReadLine());

            Feldolgozo(behelyettesitendoKarakterek, amibeBeKellHelyettesiteni, ismetlesSzam, minimumErtek, maximumertek);
        }
    }
}
