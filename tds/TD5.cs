using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TdProgrammation;

public class TD5
{   
    
    
    
    
    //Classes imbriquées
    
    //Exercice1
    public class Article
    {
        private long reference;
        private string intitule;
        private float prixHT;
        private int quantiteEnStock;
        

        public Article(long reference, string intitule, float prixHt, int quantiteEnStock)
        {
            this.reference = reference;
            this.intitule = intitule;
            this.prixHT = prixHt;
            this.quantiteEnStock = quantiteEnStock;
           
        }

        public long Reference
        {
            get{ return reference; }
        }

        public string Intitule
        {
            get { return intitule; }
        }

        public float PrixHT
        {

            get { return prixHT; }

        }

        public int QuantiteEnStock
        {
            get { return quantiteEnStock; }
        }


        public void approvisionner(int nombreUnites)
        {
            this.quantiteEnStock = this.quantiteEnStock + nombreUnites;
        }

        public bool vendre(int nombreUnites)
        {
            bool flag;
            if (this.quantiteEnStock - nombreUnites >= 0)
            {
                this.quantiteEnStock = this.quantiteEnStock - nombreUnites;
                flag = true; 
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        public float prixTTC()
        {
            //TVA dans un supermarché (en général) est 19,6%
            float prixTTC = (prixHT + prixHT * ((float)19.6 / 100));
            return prixTTC;
        }

        public String toString()
        {
            return reference + " " + intitule + " " + prixHT.ToString();
        }

        public bool equals(Article article)
        {
            return this == article;
        }
        
        
        
        

    }
    
    //Exercice2
    public class CompteBancaire
    {
        private int tentative;
        private string client;
        private double montantDuCompte;
        private bool bloque;
        public static int NombreUtilisateur { get; private set; } = 0;
        public static int NombreUtilisateurBloque { get; private set; } = 0;

        public CompteBancaire(string client,double montantDuCompte,bool bloque)
        {
            tentative = 0;
            this.client = client;
            this.montantDuCompte = montantDuCompte;
            this.bloque = bloque;
            NombreUtilisateur++;
        }


        public string Client
        {
            get { return client; }
            set { client = value; }
        }

        public double MontantDuCompte
        {
            get { return montantDuCompte; }
            set { montantDuCompte = value; }
        }

        public bool Bloque
        {
            get { return bloque; }
            set { bloque = value; }
        }
        
        public void debit(double montantDebit)
        {
            if (!bloque && this.montantDuCompte >= montantDebit)
            {
                //Débit réussi
                tentative = 0; //On réinitialise le compteur de tentative
                this.montantDuCompte = montantDuCompte - montantDebit; //On effectue le débit
            }
            else
            {
                Console.Write("Aucun débit ne peut être effectué.");
                tentative++;
                if (tentative == 2)
                {
                    bloque = true;
                    NombreUtilisateurBloque++;
                    Console.WriteLine("2 tentatives consécutives ratées : votre compte est bloqué.");
                }
                
            }

        }

        public void crediter(double montantCredit)
        {
            this.montantDuCompte = montantDuCompte + montantCredit;
            if (bloque)
            {
                this.bloque = false;
                tentative = 0;
                NombreUtilisateurBloque--;
            }
        }


        


    }
    
    
    
    
    
    
}