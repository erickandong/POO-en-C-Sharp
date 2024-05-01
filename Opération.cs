using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO  // LECON 10 : LES INTERFACES
{
    internal class Opération : IAddition, ISoustraction
    {
        public int Nb1 { get ; set ; }
        public int Nb2 { get ; set ; }

        public void Addition()
        {
            Console.WriteLine(Nb1 + Nb2);
        }

        public void Soustraction()
        {
            Console.WriteLine(Nb1 - Nb2);
        }
    }
}
