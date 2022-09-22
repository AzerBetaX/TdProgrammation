using System.Diagnostics.CodeAnalysis;

namespace TdProgrammation;

public class TD4 : TDManager
{
    public TD4(string description, Difficulte difficulte) : base(description, difficulte)
    {
    }

    //Parcours de tableaux
    public void Exercice1()
    {
        int[] tab = new int[4];
        tab[0] = 'a';
        tab[1] = 'b';
        tab[2] = 'c';
        tab[3] = 'd';
        int j = 0;
        while (j<=3)
        {
            Console.WriteLine(tab[j]);
            j++;
        }

        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine(tab[i]);
            
        }

    }



    public void Exercice3()
    {
        int[] tab = new int[6] { 15, 19, 8, 5, 17, 10 };
        int taille = tab.Length;
        for (int i = 0; i < taille; i++)
        { if (i == taille- 1)
            {
                Console.Write(i);
            }
            else
            {
                
                Console.Write(i+" ; ");
                
            }
            
        } 
    }

    public void Exercice4()
    {
        Console.WriteLine("Veuillez rentrer un nombre positif");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] tab = new int[n];
        for (int i = 1; i <= n; i++)
        {
            tab[i - 1] = i;
        }
        
        for (int i = 0; i < n; i++)
        {
            Console.Write(tab[i]+" ");
        }
    }
    

    public void Exercice5()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] tab = new int[n];
        for (int i = n; i > 0; i--)
        {
            tab[n - i] = i;
        }
        
        int j = 0;
        while (j<n)
        {
            Console.Write(tab[j]+" ");
            j++;
        }

    }

    public void Exercice6()
    {
        int n;
        Console.WriteLine("Veuillez rentrer la taille du tableau.");
        n = Convert.ToInt32(Console.ReadLine());
        int[] tab = new int[n];
        int compteurboucle = 0;
        int compteur = 0;
        while (compteur != n)
        { 
            if (compteurboucle % 2 == 1 )
            {
                tab[compteur] = compteurboucle;
                compteur++;
            }

            compteurboucle++;
               
        }

    
        for (int i = 0; i < n; i++)
        {
            Console.Write(tab[i]+" ");
        }


    }

    public void Exercice7()
    {
        int taille;
        taille = Convert.ToInt32(Console.ReadLine());
        int[] tab = new int[taille];
        for (int i = 0; i < taille; i++)
        {
            tab[i] = Convert.ToInt32(Math.Pow(2,i+1));
        }

        foreach (int nombre in tab)
        {
            Console.WriteLine(nombre + " ");
        }

    }

    public void Exercice8()
    {
        int[] tableau1 = { 15, 19, 8, 5, 17, 10 };
        int[] tableau2 = { 2, 25, 11, 6 };

        int[] tableau3 = new int[tableau1.Length + tableau2.Length];

        for (int i = 0; i < tableau1.Length; i++) tableau3[i] = tableau1[i];
        for (int j = 0; j < tableau2.Length; j++)
        {
            tableau3[tableau1.Length+j-1] = tableau2[j];
        }
        
        foreach (int nombre in tableau3)
        {
            Console.WriteLine(nombre + " ");
        }
        
    }

    public void Exercice9()
    {
        int[] tab = new int[5];
        int[] tabInverse = new int[tab.Length];

        for (int i = 0; i <= tab.Length; i++)
        {
            tabInverse[i] = tab[tab.Length - i];
        }
        
        foreach (int nombre in tabInverse)
        {
            Console.WriteLine(nombre + " ");
        }



    }

    public int[] GenererTableauAleratoire(int taille, int lowerbound , int uppderbound)
    {
        Random rand = new Random();
        int[] tab = new int[taille];
        for (int i = 0; i < taille; i++)
        {
            int val = rand.Next(lowerbound, uppderbound);
            tab[i] = val;

        }

        return tab;

    }

    public float Moyenne(int[] tab)
    {
        float somme = 0F;
        for (int i = 0; i < tab.Length; i++)
        {
            somme += tab[i];
        }

        return somme / tab.Length;
    }
    
    
    public bool Exercice11(int[] tab1, int[] tab2)
    {

        if (tab1 != null && tab2 != null)
        {
            if (tab1.Length == tab2.Length)
            {
                for (int i = 0; i < tab1.Length; i++)
                {

                    if (tab1[i] != tab2[i])
                    {
                        return false;

                    }
                    
                    
                }
                return true;
            }
            else
            {
                return false;


            }

        }
        else
        {

            return false;


        }
    }

    public void Exercice12()
    {
        Console.WriteLine("Veuillez saisir le nombre de lignes.");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Veuillez saisir le nombre de colonnes.");
        int M = Convert.ToInt32(Console.ReadLine());

        int[ , ] mat = new int[N, M];
        int compteur = 1;
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {

            }
        }
    }

    public int[,] SommeMatriciel(int[,] mat1, int[,] mat2)
    {
        if (mat1.GetLength(0) == mat2.GetLength(0) && mat1.GetLength(1) == mat2.GetLength(1))
        {
            
            int[,] mat3 = new int[mat1.GetLength(0), mat1.GetLength(1)];

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    mat3[i, j] = mat1[i, j] + mat2[i, j];


                }
                
                
            }

            return mat3;
        }
        else
        {
            
            Console.WriteLine("");
            return null;
        }
    }

    public int[,] ProduitMatriciel(int[,] mat1, int[,] mat2)
    {
        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.GetLength(1); j++)
            {
                
                
                
            }
            
            
        }
        
        
        
        
        
    }
   
    
    
    
    
}