using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Poisson : Animal
    {
        //Attribut
        public bool eauFroide;

        //Constructeur
        public Poisson(string nom, int age, bool eauFroide) : base(nom, age)
        {
            this.eauFroide = eauFroide;
        }

        //methodes
        public void parler()
        {
            Console.WriteLine("Gloup Gloup");
        }

        public void Nager()
        {
            Console.WriteLine(Nom + " nage...");
        }

        

    }
}
