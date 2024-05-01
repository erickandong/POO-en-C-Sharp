using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Chien : Animal

    {
        //Attribut
        public int NrTatouage;

        //Constructeur
        public Chien(string nom, int age, int nrTatouage) : base(nom, age)
        {
         this.NrTatouage = nrTatouage;
        }

        //methodes
        public void Aboyer()
        {
            Console.WriteLine("Wouf Wouf");
        }

        public void Courrir()
        {
            Console.WriteLine(Nom + "cours...");
        }

                                            // public "new" void ... lui va permettre de reutiliser la methode de la classe Animal
        public sealed override void AfficheInfo() //substitue la methode de la classe Animal en utilisant celle de la classe Chien
                                           //On peut aussi sceller des methodes à l'aide du modificateur "sealed"
        {
            Console.WriteLine("Je suis un chien , je me nomme " + Nom);
            Console.WriteLine("J'ai " + Age + " an(s). ");
        }
    }
}
