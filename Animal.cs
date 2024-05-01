using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //LECON 5: L'ABSTRACTION : permettra de rendre la classe Animal abstraite (on ne pourra plus l'appeler dans le programme principal)
    abstract internal class Animal 
    {

        //La classe est unpeu comme un moule à gateau

        //LECON 0 : LES ATTRIBUTS (est une variables de classe) de la classe Animal

        //public string Nom; //en majuscule quand c'est une variable public
        //public int Age;

        //LECON 2 : CONSTRUCTEUR PAR DEFAUT: permet d'agir sur l'extension d'un objet
        //public Animal()
        //{

        //}

        //Deuxième constructeur
        //public Animal(string Nom, int Age)
        //{
        // this.Nom = Nom;
        // this.Age = Age;
        //}


        // LECON 1 : METHODE DE CLASSE

        //public void AfficheInfo()
        // {
        //Console.WriteLine("Je suis " + Nom);
        //Console.WriteLine("J'ai " + Age + " an(s). ");
        // }





        //LECON 3 : LES PROPRIETES ou ENCAPSULATEURS


        //Les attributs (est une variables de classe) de la classe Animal
        private string _nom; //en majuscule quand c'est une variable public
        private int _age;

          // protected string Surnom;   //LECON 8 : LE MODIFICATEUR D'ACCES "PROTECTED"
                                   //uniquement utilisable dans la classe propriétaire de l'attribut

        //Premiere facon de faire
        public string Nom
        {
            get   //Accesseurs ou Guetteurs: permet si on veut de modifier le nom
            { 
                return _nom; 
            }

            set    //Mutateurs ou Seteurs
            {
                //_nom = value; 
                // ou on peut décider de ne pas modifier la valeur du nom
                Console.WriteLine("Le nom ne peut etre changer");
            }
        }

        public int Age
        {
            get   //Accesseurs ou Guetteurs: permet  de lire/d'obtenir le nom
            {
                return _age;
            }

            set    //Mutateurs ou Seteurs: : permet  si on veut de modifier le nom
            {
                if (value>0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("l'age doit etre supérieur à 0 ");
                }
              
            }
        }

        //Deuxième facon de faire
        //private string Nom { get; private set };


        //LECON 2 : CONSTRUCTEUR PAR DEFAUT: permet d'agir sur l'extension d'un objet
        public Animal()
        {

        }

        //Deuxième constructeur
        public Animal(string Nom, int Age)
        {
            this._nom = Nom;
            this._age = Age;
        }


        //LECON 1 : METHODE DE CLASSE
        public virtual void AfficheInfo()  //LECON 6: POLYMORPHISME virtual permet d'etre substitué dans une classe dérivée(enfant)
        {
            Console.WriteLine("Je suis un animal , je me nomme " + _nom);
            Console.WriteLine("J'ai " + _age + " an(s). ");
        }

        //LECON 8 : LE MODIFICATEUR D'ACCES "PROTECTED"
        //On peut également créé des méthodes protégés

        protected void ProtectedMethod() 
        {
            Console.WriteLine(); //on l'appelle uniquement dans la classe qui la possède
        }

    }
}
