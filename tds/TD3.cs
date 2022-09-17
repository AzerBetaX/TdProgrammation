namespace TdProgrammation;

public class TD3 : TDManager
{
    public TD3(string description, Difficulte difficulte) : base(description, difficulte)
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
        
        
        
        
        
    }
    
    
    
    public bool Exercice10(int[] tab1, int[] tab2)
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
        
        
        
        
    }
   
    
    
    
    
}