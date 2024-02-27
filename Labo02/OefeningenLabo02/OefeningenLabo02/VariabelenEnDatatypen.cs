using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLabo02
{
    internal class VariabelenEnDatatypen
    {
        public static void H2_Optellen()
        {
            Console.WriteLine("Wat is het eerste getal?");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is het tweede getal?");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = FirstNumber + SecondNumber;
            Console.WriteLine("De som is " + sum);
        }
        public static void H2_Verbruik_Wagen()
        {
            Console.WriteLine("Hoeveel liter is er nog in de benzinetank?");
            float Begin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel liter is er nog in de benzinetank na de rit?");
            float Einde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is de kilometer stand?");
            float KMBegin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is de kilometer stand na de rit?");
            float KMEinde = Convert.ToInt32(Console.ReadLine());
            float Average = (100 * (Begin - Einde) / (KMEinde - KMBegin));
            Console.WriteLine("Het verbruik is = " + Average);


        }
        public static void H2_Beetje_Wiskunde()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) * 7);
            Console.WriteLine(14 - 4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 * 2);
        }


        public static void H2_gemiddelde()
        {
            Console.WriteLine((18 + 11 + 8) / 3);
        }

        public static void H2_maaltafels()
        {
            Console.WriteLine("Met wat wil je van 1 tot 10 vermenigvuldigen?");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(input * 1);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(input * 2);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(input * 3);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(input * 4);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(input * 5);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(input * 6);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(input * 7);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(input * 8);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(input * 9);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(input * 10);
            Console.ReadLine();
            Console.Clear();


        }
        public static void H2_Ruimte()
        {
            Console.WriteLine("What is your weight?");
            double weight = Convert.ToInt32(Console.ReadLine());

            double MercuryW = weight * 0.38;
            Console.WriteLine("On mercury you'd feel like " + MercuryW + ".");

            double VenusW = weight * 0.91;
            Console.WriteLine("On Venus you'd feel like " + VenusW + ".");

            double EarthW = weight * 1;
            Console.WriteLine("On Earth you'd feel like " + EarthW + ".");

            double MarsW = weight * 0.38;
            Console.WriteLine("On Mars you'd feel like " + MarsW + ".");

            double JupiterW = weight * 2.34;
            Console.WriteLine("On Jupiter you'd feel like " + JupiterW + ".");

            double SaturnW = weight * 1.06;
            Console.WriteLine("On Saturn you'd feel like " + SaturnW + ".");

            double UranusW = weight * 0.92;
            Console.WriteLine("On Uranus you'd feel like " + UranusW + ".");

            double NeptuneW = weight * 1.19;
            Console.WriteLine("On Neptune you'd feel ike " + NeptuneW + ".");

            double PlutoW = weight * 0.06;
            Console.WriteLine("On Pluto you'd feel like " + PlutoW);

        }
        public static void H2_Fietsenverkoper()
        {
            Console.WriteLine("Wat is de inkoop prijs?");
            double inkoop = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoeveel bedraagt de btw?");
            int BTW = Convert.ToInt32(Console.ReadLine());
            double Prijs = inkoop * (BTW / 100);
            Console.WriteLine("De prijs van de fiets inclusief BTW =" + Prijs + ".");
        }
        public static void DemoOefening1()
        {
            Console.WriteLine("Geef uw naam aub.");
            string name = Console.ReadLine();
            Console.WriteLine("Wat is uw leeftijd?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hallo {name} je bent {age} jaar oud");
            int IncreaseAgeWith = 10;
            Console.WriteLine($"Hallo {name} je bent over");


            //nog niet afgemaakt
        }
        public static void H3_MaaltafelsStringInterpolatie() 
        {
            Console.WriteLine("Geef een nummer waarvan je de maaltafel t.e.m. 10 wilt");
            int maaltafel = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.ReadLine();
            Console.WriteLine(maaltafel * 1);
            Console.Clear();
            Console.ReadLine();
            Console.WriteLine(maaltafel * 2);
            Console.Clear();
            Console.ReadLine();
            Console.WriteLine(maaltafel * 3);
            Console.Clear();
            Console.ReadLine();
            Console.WriteLine(maaltafel * 4);
            Console.Clear();
            Console.ReadLine();
            Console.WriteLine(maaltafel * 5);
            Console.Clear();
            Console.ReadLine();
            Console.WriteLine(maaltafel * 6);
            Console.Clear();
            Console.ReadLine();
            Console.WriteLine(maaltafel * 7);
            Console.Clear();
            Console.ReadLine();
            Console.WriteLine(maaltafel * 8);
            Console.Clear();
            Console.ReadLine();
            Console.WriteLine(maaltafel * 9);
            Console.Clear();
            Console.ReadLine();
            Console.WriteLine(maaltafel * 10);
        }
        public static void H3_Berekenen_BTW() 
        { 
        Console.WriteLine("Geef het bedrag.");
            int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Geef de BTW");
            int BTW = Convert.ToInt32(Console.ReadLine());
            
            int result = value + (value/100)*BTW;
        Console.WriteLine($"Het bedrag {value} met {BTW}% bedraagt {result}");
        }
        public static void H3_Leetspeak() 
        {
            Console.WriteLine("Schrijf een zin.");
            string Sentence = Console.ReadLine();
            string SentenceV2 = Sentence.Replace(" ","");
            string SentenceV3= SentenceV2.Replace("a", "@");
            Console.WriteLine(SentenceV3);
        }
        public static void H3_Instructies() 
        {
            Console.WriteLine("Wat is je naam?");
            string name = Console.ReadLine();
            string CapitalName = name.Substring(0,3).ToUpper();
            Console.WriteLine("Wat is de naam van je cursus?");
            string course = Console.ReadLine();

            Console.WriteLine($"Maak een map als volgt: /Home/{CapitalName}/{course}");
        }
        public static void H3_Lotto()
        {
            Console.WriteLine("Wat zijn je cijfers? (Tussen 01 en 45)");
            string FullNumber = Console.ReadLine();
            string FirstNumber = FullNumber.Substring(0, 2);
            string SecondNumber = FullNumber.Substring(3, 2);
            string ThirdNumber = FullNumber.Substring(6, 2);
            string FourthNumber = FullNumber.Substring(9, 2);
            string FifthNumber = FullNumber.Substring(12, 2);
            string SixthNumber = FullNumber.Substring(15, 2);

            Console.WriteLine("Je Cijfers zijn:");
            Console.WriteLine($"{FirstNumber}|{SecondNumber}|{ThirdNumber}");
            Console.WriteLine($"{FourthNumber}|{FifthNumber}|{SixthNumber}");
        }
        public static void H3_Som_Van_Cijfers()
        {
            Console.WriteLine("Gelieve een getal in te te voeren dat bestaat uit precies 5 decimale cijfers.");
            string decimalnumber = Console.ReadLine();
            int FirstNumber = Convert.ToInt32(decimalnumber.Substring(0, 1));
            int SecondNumber = Convert.ToInt32(decimalnumber.Substring(1, 1));
            int ThirdNumber = Convert.ToInt32(decimalnumber.Substring(2, 1));
            int FourthNumber = Convert.ToInt32(decimalnumber.Substring(3, 1));
            int FifthNumber = Convert.ToInt32(decimalnumber.Substring(4, 1));
            int sum = (FirstNumber+SecondNumber+ThirdNumber+FourthNumber+FifthNumber);
            Console.WriteLine($"De som is {sum}");
        }
        public static void H3_Naam_Uit_Mail()
        {
            Console.WriteLine("Geef je e-mailadres op:");
            string email = Console.ReadLine();
            Int32 index = email.IndexOf("@");
            string name = email.Substring(0, index);
            string nameupper = name.ToUpper();
            Console.WriteLine($"Je naam uit je e-mail is: {nameupper}");
        }
        public static void H3_Toegangscode()
        {
            Console.WriteLine("Geef je naam:");
            string name = Console.ReadLine();
            int lenghtname = name.Length;
            string firstchar = name.Substring();
            Console.WriteLine(name);

            // string firstindex = Convert.ToString(name.IndexOf));
            //Console.WriteLine(firstindex);

            /*
            Console.WriteLine("Geef je geboortejaar:");
            string yearofbirth = Console.ReadLine();
            Console.WriteLine("Geef je postcode:");
            int zipcode = Convert.ToInt32(Console.ReadLine());
            */

        }
    }
}




