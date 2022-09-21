using System.Runtime.CompilerServices;
using System.Text;

namespace TdProgrammation;

public class TD6
{

    public static void Main()
    {
        Commune Paris = new Commune("Paris",75, "France","Hidalgo",2200000) ;
        Commune Rouen = new Commune("Rouen",76, "France","Robert",111000) ;
        Paris.Population = 2220000 ;//Paris c'est mieux
        Rouen.Population = 1000; //Qui veut habiter à Rouen ..?
        string sParis = Paris.toString();
        string sRouen = Rouen.toString();
        //Afficher les caractéristiques avec la méthode toString()
        Console.WriteLine(sParis);
        Console.WriteLine(sRouen);
    }
    //Classes imbriquées
    public class Commune
    {
        private string nom;
        private int departement;
        private string pays;
        private string maire;
        private int population;
        public Commune(string nom,int departement,string pays,string maire,int population)
        {
            if (departement <= 0)
            {
                this.departement = -1;
            }
            else
            {
                this.departement = departement;
            }

            if (population <= 0)
            {
                this.population = -1;
            }
            else
            {
                this.population = population;
            }

            this.pays = pays.ToUpper();
            this.nom = nom.ToUpper();
            this.maire = maire.ToLower();
        }

        public string toString()
        
        {   //On pourrait utiliser un StringBuilder...
            string description = this.nom + " est une commune de " + population + " habitants dont le pays est " +
                                 pays + " dans le département " + departement +"."
                                 + " Cette commune est gérée par " + maire;
            return description;
        }

        public bool equals(Commune commune)
        {
            return this.population == commune.population; 
        }

        public static bool equalStatic(Commune commune1,Commune commune2)
        {
            return commune1.population == commune2.population;
        }

        public int Population
        {
            get { return population;}
            set
            {
                if (value <= 0)
                {
                    population = -1;
                }
                else
                {
                    population = value;
                }
                
            }
        }

        public string Maire
        {
            get { return maire;}
            set { maire = value; }
        }

        public int Departement
        {
            get { return departement; }
        }

        public string Pays
        {
            get { return pays; }
        }

        public string Nom
        {
            get { return nom; }
        }
        
        

    }
    
    //Exercice2
    
    
    
}