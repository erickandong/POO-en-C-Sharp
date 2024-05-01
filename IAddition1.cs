using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal interface IAddition
    {
        int Nb1 { get; set; }
        int Nb2 { get; set; }

        void Addition();
    }

    internal interface ISoustraction
    {
        int Nb1 { get; set; }
        int Nb2 { get; set; }

        void Soustraction();
    }
}
