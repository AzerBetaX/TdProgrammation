using System;
namespace TdProgrammation;

public class TD1 : TDManager
{

    protected TD1(string description, Difficulte difficulte) : 
        base(description, difficulte)
    {
        
        
        
        
        
    }
    
    
   

    static void Exercice2()
    {
        //
        String prenom = Console.ReadLine();
        Console.WriteLine("Bonjour " + prenom);
        Console.WriteLine("Comment vas-tu ?");
        
    }

    static void Exercice3()
    {
        int x = 0;
        int y = 0;
        int z = 0;
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        x = 5;
        y = 17;
        z = 31;
        z = x * y;
        z += y;
        y += 7;
        x += 8;
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);

    }

    static void Exercice4()
    {
        double ht;
        double tva;
        int nb;
        ht = Convert.ToDouble(Console.ReadLine());
        nb = Convert.ToInt32(Console.ReadLine());
        tva = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(nb*(ht + tva*ht));
        
        
    }

    static void Exercice5()
    {
        double x, y;
        Console.Write("Entrer la longueur du rectangle :");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Entrer la largeur du rectangle :");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("La surface du rectangle est " + x*y +"\n");
        Console.Write("Le périmètre du rectangle est " + 2*x+2*y);

    }

    static void Exercice6()
    {
        int x, y;
        Console.Write("Entrer un premier nombre :");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entrer un seconde nombre :");
        y = Convert.ToInt32(Console.ReadLine());
        Console.Write("La somme est :" + (x+y) + "\n");
        Console.Write("La différence est " + (x-y)+ "\n");
        Console.Write("Le produit est " + (x*y)+ "\n");
        float z = 0.0F;
        z = (float)x / (float)y;
        Console.Write("la division est " + z+ "\n");
        z = ((float)x + (float)y)/ 2;
        Console.WriteLine(z);




    }

    static void Exercice8()
    {
        int x;
        x = Convert.ToInt32(Console.ReadLine());
        if (x % 2 == 0)
        {
            Console.WriteLine(x + "est pair");
            
        }
        else
        {
            Console.WriteLine(x + "est impair");
        }



    }

    static void Exercice9()
    {
        int x, n;
        x = Convert.ToInt32(Console.ReadLine());
        n = Convert.ToInt32(Console.ReadLine());
        if (x % n == 0)
        {
            Console.WriteLine(x + "est un multiple de " + n);
            
            
        }
        else
        {
            Console.WriteLine(x + "n'est pas un multiple de " + n);
        }
    }

    static void Exerciece10()
    {
        /*
         * On part de ax + b = cx + d
         *        <=> x(a-c) = d-b
         *        <=> x = (d-b)/(a-c) si a!=c  
         *
         * 
        */
        int a, b, c, d;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        d = Convert.ToInt32(Console.ReadLine());

        if (a != c)
        {
            if (b != d)
            {
                Console.WriteLine("Il est existe une solution car a!=c");
                Console.WriteLine((float)(d-b)/(float)(a-c));
                
            }
            else
            {
                Console.WriteLine("Il est existe une solution qui x = 0");
            }
            
            
            
            
        }
        else
        {
            Console.WriteLine("Il n'y a pas de solution à cette équation.");
            
            
        }
        
        
    }

    static void Exercice11()
    {
        int x, y;
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        if (x <= y) Console.WriteLine(x);
        else Console.WriteLine(y);

    }


    static void Exercice12()
    {

        int n, m;
        n = Convert.ToInt32(Console.ReadLine());
        m = Convert.ToInt32(Console.ReadLine());
        if (n > m)
        {
            Console.WriteLine("ERREUR");
        }
        else
        {
            int  x = Convert.ToInt32(Console.ReadLine());
            if (x >= n && x <= m)
            {
                Console.WriteLine("Oui il fait partie de l'intervalle");
                
            }
            
            
        }


    }

    static void Exerceice13()
    {

        int s, e, p;
        s = Convert.ToInt32(Console.ReadLine());
        e = Convert.ToInt32(Console.ReadLine());
        p = Convert.ToInt32(Console.ReadLine());
        if (s == e && e == p)
        {
            Console.WriteLine("Tous égaux");
            
        }
        else
        {
            Console.WriteLine("Dommage, pas d'égalité");
            
        }

    }

    static void Exercice14()
    {
        int nb;
        Console.WriteLine("Rentrer un chiffre entre 1 et 7");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x >= 1 && x <= 7)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine("RLundi");
                    break;
                case 2:
                    Console.WriteLine("Mardi");
                    break;
                case 3:
                    Console.WriteLine("Mercredi");
                    break;
                case 4:
                    Console.WriteLine("Jeudi");
                    break;
                case 5:
                    Console.WriteLine("Vendredi");
                    break;
                case 6:
                    Console.WriteLine("Samedi");
                    break;
                case 7:
                    Console.WriteLine("Dimanche");
                    break;
                
            }
            
            
        }
        else
        {
            
            Console.WriteLine("ERROR");
        }



    }


   
}