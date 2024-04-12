
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_oop4
{
    internal class namn
    {
        private string helnamn;
        private string förnamn;
        private string efternamn;
        private double höjd;
        private double vikt;

        public string Förnamm
        {
            get { return förnamn; }

            set { förnamn = value; }
        }

        public string Efternamn
        {
            get { return efternamn; }

            set { efternamn = value; }
        }

        public double Höjd
        {
            get { return höjd; }

            set { höjd = value; }

        }

        public double Vikt
        {
            get { return vikt; }

            set { vikt = value; }

        }

        public double Bmi()
        {
            double bmi = vikt / (höjd * höjd);
            return bmi;
        }
        public void Namn()
        {
            helnamn = förnamn + " " + efternamn;
            Console.WriteLine("Hej " + helnamn);
        }
    }
}
