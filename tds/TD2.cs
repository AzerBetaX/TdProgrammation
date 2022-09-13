using ClassLibrary1.utils;

namespace TdProgrammation;

public class TD2 : TDManager
{
    public TD2(string description, Difficulte difficulte) : base(description, difficulte)
    {
    }
    
    
    
    

    static void Exercice1()
    {
        double temperature;
        temperature = Convert.ToDouble(Console.ReadLine());
        
        if (temperature > 0 && temperature <= 10)
        {

        }
        




    }

    static void Exercice2()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void Exercice3()
    {
        //Sous réserve que n soit positif
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(n-i);
        }
    }

    public void Exercice4()
    {
        Console.WriteLine("UN ENTIER STRICTEMENT POSITIF SVP");
        int n = Convert.ToInt32(Console.ReadLine());
        while(n > 0){
            Console.WriteLine("MAUVAIS FORMAT. UN ENTIER STRICTEMENT POSITIF SVP");
            n = Convert.ToInt32(Console.ReadLine());
            
        }

        Console.WriteLine("OK.");
        
    }
    //Année bissextile
    public void Exercice5()
    {
        Console.WriteLine("Veuillez rentrer une année.");
        int annee = Convert.ToInt32(Console.ReadLine());
        if ((annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0)
        {
            Console.WriteLine(annee + " est une année bissextile.");
        }
        else
        {
            Console.WriteLine(annee + " n'est pas une année bissextile.");
        }
    }
    
    //Somme des n premiers nombres entiers
    public void Exercice6()
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        int somme = 0;
        for (int i = 1; i <= n; i++)
        {
            somme += i;
        }
        Console.WriteLine("La somme des " + n + "premiers nombres entiers vaut " + somme);
    }
    
    //Table de multiplication
    public void Exercice7()
    {
        int n;
        Console.WriteLine("Veuillez rentrer un entier entre 1 et 100.");
        n = Convert.ToInt32(Console.ReadLine());
        while (!(1 <= n && n <= 100))
        {
            Console.WriteLine("Mauvaise valeur. Veuillez rentrer un entier entre 1 et 100.");
            n = Convert.ToInt32(Console.ReadLine()); 
        }
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i+"*"+n+" = " +n*i);
        }
    }

    //Carré d'étoiles
    public void Exercice8()
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\r");
        }
    }

    //Triangle-rectangle d'étoiles
    public void Exercice9()
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\r");
        }
    }
    
    //Triangle isocèle d'étoiles
    public void Exercice10()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int p = 0;
            for (int k = 1; k <= n - i; k++)
            {
                
                Console.Write("  ");
            }

            while (p != 2*i - 1)
            {
                Console.Write("* ");
                p++;
            }

            Console.Write("\n");
        }
    }
    //Sablier
    public void Exercice11()
    {

        Console.WriteLine("Saisir la hauteur du sablier");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i<n;i++)
        {
            for (int j = 0; j < i; j++) 
                Console.Write(" ");

            for (int k = (n * 2 - 1); k > i * 2; k--) 
                Console.Write("*");
            
            Console.Write("\n");
        }
        
    }
    //Matrice d'étoiles (starMatrix)
    public void Exercice12()
    {
        Random generateur = new Random();
        int n;
        Console.WriteLine("Veuillez rentrer le nombre de ligne souhaitées.");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 60; j++)
            {
                int nombreCache = generateur.Next(1, 3);
                if (nombreCache == 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("\n");
        }
    }
    
    //Termes d'une suite
    public void Exercice13()
    {
        int somme = 0;
        int u_0 = 2;
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Le terme pour n = 0 est " + u_0);
        somme += u_0;
        for (int i = 1; i < n; i++)
        {
            u_0 = 5*u_0 + 1;
            somme += u_0;
             Console.WriteLine("Le terme pour n = "+ i +" est " + u_0);
        }

        Console.WriteLine("La somme de ces termes est égale à " + somme);

    }

    public void Exercice14()
    {
        Console.WriteLine("Saisir la hauteur de la pyramide");
        int n;
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i<n;i++)
        {
            for (int j = 0; j < i; j++) 
                Console.Write(" ");

            for (int k = (n * 2 - 1); k > i * 2; k--) 
                Console.Write("*");
            
            Console.Write("\n");
        }
    }


    public void Exercice15()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int multiplication = 0;
        
        for (int i = 1; i <= m; i++)
        {
            multiplication += n;
        }
        
        Console.WriteLine(multiplication); 
    }

    static int multiplicationM(int a, int b)
    {
        int multiplication = 0;
        
        for (int i = 1; i <= a ;i++)
        {
            multiplication += b;
        }

        return multiplication;

    }
    //Puissance à l'aide des multiplications
    public void Exercice16()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int temp = a;
        int b = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i < b; i++)
        {
            a *= temp;
        }
        
        Console.WriteLine("Le résultat de " + temp + " puissance " + b + " est " + a);
    }
    

    //Parité d'un nombre
    public void Exercice17()
    {
        int n;
        Console.WriteLine("Veuillez saisir un nombre strictement positif");
        n = Convert.ToInt32(Console.ReadLine());
        while (n <= 0)
        {
            Console.WriteLine("Veuillez saisir un nombre strictement positif");
            n = Convert.ToInt32(Console.ReadLine());
        }
        
       



    }

    public void Exercice18()
    {
        Console.WriteLine("Veuillez rentrer un entier strictement positif.");
        int n = Convert.ToInt32(Console.ReadLine());
        while(n > 0){
            Console.WriteLine("MAUVAIS FORMAT. Veuillez rentrer un entier strictement positif.");
            n = Convert.ToInt32(Console.ReadLine());
        }
        
        int factorielle = 1;
        for (int i = 1; i <= n; i++)
        {
            factorielle *= i;
        }

        Console.WriteLine(factorielle);
    }
    
    //PGDC de deux nombres
    public void Exercice21()
    {
      
        
        
        
    }
    
    
    //Nombre mystère
    public void Exercice22()
    {
        Random generateur = new Random();
        int nombreCache = generateur.Next(1, 401); //Borne supérieure n'est pas incluse.
        Console.WriteLine("Veuillez entrer un nombre.");
        int proposition = Convert.ToInt32(Console.ReadLine());
        while (proposition != nombreCache)
        {
            if (proposition < nombreCache)
            {
                Console.WriteLine("Trop petit !");
                Console.WriteLine("Veuillez entrer un nombre.");
                proposition = Convert.ToInt32(Console.ReadLine());
            }

            if (proposition > nombreCache)
            {
                Console.WriteLine("Trop grand !");
                Console.WriteLine("Veuillez entrer un nombre.");
                proposition = Convert.ToInt32(Console.ReadLine());
            }
            
            

        }
        
        Console.WriteLine("Bravo ! Le nombre caché était effectivement " + nombreCache);

    }

    public void Exercice23()
    {
        /*
         * Calcul des n premiers termes de la suite de Finonnaci.
         */
        
        Console.WriteLine("Veuillez saisir un entier positif n.");
        int f_0 = 0;
        int f_1 = 1;
        int n = Convert.ToInt32(Console.ReadLine());
        int somme = 0;
        switch (n)
        {
            case 0:
                Console.WriteLine("Les termes de la suite de Fibonnaci de 0 à " + n + " sont :");
                Console.WriteLine("F(0) = " + f_0);
                break;
            case 1:
                Console.WriteLine("Les termes de la suite de Fibonnaci de 0 à " + n + " sont :");
                Console.WriteLine("F(0) = " + f_0);
                Console.WriteLine("F(1) = " + f_1);
                somme += f_1;
                break;
            default:
                Console.WriteLine("Les termes de la suite de Fibonnaci de 0 à " + n + " sont :");
                Console.WriteLine("F(0) = " + f_0);
                Console.WriteLine("F(1) = " + f_1);
                somme += f_1;
                for(int i = 2; i < n;i++)
                {
                    f_1 += f_0;
                    f_0 = f_1 - f_0;
                    somme += f_1;
                    Console.WriteLine("F("+i+") = " + f_1);
                }
                break;
        }
        Console.WriteLine("La somme des premiers termes de la suite de Fibonnaci pour n = "+n+" est " + somme);
    }

    public void Exercice24()
    {
        Console.WriteLine("Entrer un mot de passe à 6 caractères.");
        int tries = 1;
        String pass = Console.ReadLine();
        
        while (pass.Length != 6)
        {
            Console.WriteLine(tries + "ème essaie. " + "Mauvais format. Veuillez rentrer un mot de passe d'une longueur de 6 caractères.");
            pass = Console.ReadLine();
            tries++;
        }
        
        Console.WriteLine("Le mot de passe est dans le bon format : " + pass);
    }


    static void Exercice25()
    {
        
        
        
        
    }

    static Boolean estpositif(int n)
    {

        if (n >= 0)
        {
            return true;
            
        }
        else
        {

            return false;

        }
        
        
        
    }
    
    
    public void Exercice26()
    {
        int n = Convert.ToInt32(Console.ReadKey());

        if (estpositif(n))
        {
            String str = factorielle.ToString();
            Console.WriteLine(str);

        }
        else
        {
            Console.WriteLine("Mauvais signe du nombre");
            
        }
        
        
        
        
        
        
        
        
        
        
    }
    
    
    
    

}