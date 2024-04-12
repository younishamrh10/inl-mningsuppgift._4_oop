using System;

namespace inlämningsuppgift._4_oop 
{
    class Program
    {
        static void Main(string[] args)
        {
            namn p = new namn();
            Console.WriteLine("Förnamn?");
            p.Förnamm = Console.ReadLine();
            Console.WriteLine("Efternamn?");
            p.Efternamn = Console.ReadLine();
            Console.WriteLine("");
            p.Namn();

            bool myndig = false;
            Console.WriteLine("");
            Console.WriteLine("Vilket år är du född?");
            int år = int.Parse(Console.ReadLine());
            Console.WriteLine("Vilken månad är du född?");
            int månad = int.Parse(Console.ReadLine());
            Console.WriteLine("Vilken dag är du född?");
            int dag = int.Parse(Console.ReadLine());
            DateTime nu = DateTime.Today;
            DateTime årsedan = DateTime.Today.AddYears(-18);
            DateTime person = new DateTime(år, månad, dag);

            if (person < årsedan)
            {
                myndig = true;
            }

            Console.WriteLine("Din myndighetsstatus är " + myndig);
            Console.WriteLine("");
            Console.WriteLine("Hur mycket väger du i kg?");
            p.Vikt = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur lång är du i m?");
            p.Höjd = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Ditt Bmivärde är " + p.Bmi());

        }
    }
}