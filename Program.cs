using System;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //L'execution de la classe est unpeu comme le cateau qui en ressort

            //Onjet: monAnimal
            //Animal  MonAnimal = new Animal();
            //MonAnimal.Age = 2;
            //MonAnimal.Nom = "Brutus";
            //MonAnimal.AfficheInfo();

            Console.WriteLine();

            //Exécution du deuxieme constructeur
            //Objet: ani0 
            // Animal ani0 = new Animal("Fox", 4);
            //ani0.AfficheInfo();

            Console.WriteLine();

            //Test pour les getteurs et les setteurs
            //Objet: ani1
            // Animal ani1 = new Animal("Rex", 5);
            //Console.WriteLine(ani1.Nom);

            //ani1.Age = 0;
            //Console.WriteLine(ani1.Age);

            //ani1.AfficheInfo();


            Console.WriteLine();

            //LECON 4: NOTION D'HERITAGE

            //Classe Chien: qui hérite de la classe Animal
            Chien chien1 = new Chien("Euro", 3, 452 );
            chien1.AfficheInfo();
            chien1.Aboyer();

            Console.WriteLine();
            //Classe Poisson: qui hérite également de la classe Animal
            Poisson poisson1 = new Poisson("Nemo", 6, true);
            poisson1.AfficheInfo();
            poisson1.Nager();


            Console.WriteLine();
            //LECON 6: POLYMORPHISME il s'applique uniquement aux méthodes
            Chien chien2 = new Chien("Rocky", 8, 605);
            chien2 .AfficheInfo(); //celui de la classe Chien car il a été substitué avec "override"




            // LECON 7 : LE MODIFICATEUR "SEALED"

            // Sealed internal class Animal :
            // cette syntaxe empeche l'héritage sur une autre classe enfant



            //LECON 8 : LE MODIFICATEUR D'ACCES "PROTECTED"



            Console.WriteLine();
            //LECON 9: LES STRUCTURES "struc"

            Personne pers; //On n'a pas besoin de new pour l'appeler
            pers.nom1 = "Ndong";
            pers.prenom1 = "Ericka";
            pers.Parler();
            //La structure ne peut pas hériter d'une autre structure ou mm d'une classe
            //On l'utilise généralement pour stocker des données peu volumineuse 
            //Elle ne permet pas de masquer des données,et ne gère pas la notion d'héritage




            Console.WriteLine();
            // LECON 10 : LES INTERFACES 
            //on a crée la classe Opération et deux interfaces IAddition et ISoustraction
            Opération op = new Opération();
            op.Nb1 = 10;
            op.Nb2 = 20;

            op.Addition();
            op.Soustraction();

            Console.ReadKey();  

        }
    }

}
