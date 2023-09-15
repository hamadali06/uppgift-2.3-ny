using System;
namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string kostnad = "kostnaden för kilometer: ";
            Console.WriteLine("Hur Många dagar ska du låna bilen?");
            string x = Console.ReadLine();
            int dagar = Convert.ToInt32(x);
            Console.WriteLine("Antal kilometer som du ska köra");
            string k = Console.ReadLine();
            int t = Convert.ToInt32(k);
            int km = t * 1;
            int total = 300 + (500 * dagar) - 500 + km;
            string pris = "Kostnaden är: ";
            Console.WriteLine(pris + " " + total + "kr");

        }
    }
}