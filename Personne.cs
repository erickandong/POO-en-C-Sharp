using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO  //LECON 9: LES STRUCTURES "struc"
{
    
    struct  Personne
    {
        public  string nom1;
        public  string prenom1;

        public Personne(string _nom1, string _prenom1) //Les structures exigent des constructeurs non-vides; 
                                                       //Tous les attributs doivent faire partis du constructeurs
        {
            nom1 = _nom1;
            prenom1 = _prenom1;
        }

        public void Parler()
        {
            Console.WriteLine(nom1 + " parle...");
        }
    }
}
