using System.Diagnostics.CodeAnalysis;

namespace TdProgrammation;

public class TD4 : TDManager
{
    public TD4(string description, Difficulte difficulte) : base(description, difficulte)
    {
    }

    public static void Main()
    {

        Exercice4();


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

    public static void Exercice4()
    {
        Console.WriteLine("Veuillez rentrer un nombre positif");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] tab = new int[n];
        for (int i = 0; i < n; i++)
        {
            tab[i] = i+1;
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

    public void Exercice10()
    {

        int nb = Convert.ToInt32(Console.ReadLine());
        int[] tab = new int[nb];

        for (int i = 0; i < nb; i++)
            tab[i] = Convert.ToInt32(Console.ReadLine());
        int somme = 0;
        for (int i = 0; i < nb; i++)
            somme += tab[i];

        Console.WriteLine("La moyenne des " + nb + " ??l??ments est ==> " + (float)((float)somme / (float)nb));
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
                mat[i, j] = compteur;
                compteur++;
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
            
            Console.WriteLine("Pas possible de faire la somme de deux matrices de diff??rentes tailles.");
            return mat1;
        }
    }

    public int[,] ProduitMatriciel(int[,] mat1, int[,] mat2)
    {
        int[,] mat3 = new int[mat1.GetLength(0), mat2.GetLength(1)];
        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat2.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < mat1.GetLength(1); k++)
                {
                    sum += mat1[i, k] * mat2[k, j];
                }

                mat3[i, j] = sum;
            }
        }

        return mat3;
    }

    public void Exercice14()
    {
        int[,] mat1 = new int[2,3];
        int[,] mat2 =new int[3,2];
        
        if (mat1.GetLength(1) == mat2.GetLength(0))
        {
            int[,] mat3 = ProduitMatriciel(mat1, mat2);
            for (int k = 0; k < mat3.GetLength(0); k++)
            {
                for (int j = 0; j < mat3.GetLength(1); j++)
                {
                    Console.Write(mat3[k, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else Console.WriteLine("Produit matriciel non possible");
    }


    public void TriBulles(int[] tab)
    {
        for (int i = tab.Length - 1; i >= 0; i--)
        {
            bool tabTri = true;
            for (int j = 0; j <= i - 1; j++)
            {
                if (tab[j + 1] < tab[j])
                {
                    int temp = tab[j];
                    tab[j] = tab[j + 1];
                    tab[j + 1] = temp;
                    tabTri = false;
                }
            }

            if (tabTri) break; //after de terminer dans le cas triviam
        }
    }






}