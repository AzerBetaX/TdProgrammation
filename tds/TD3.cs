namespace TdProgrammation;

public class TD3 : TDManager
{
    public TD3(string description, Difficulte difficulte) : base(description, difficulte)
    {
        
        
    }
    //Exercice0
    public int SaisiePositif()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        while (n <= 0)
        {
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mauvaise saisie. Veuillez rentrer un entier strictement positif.");
            
        }

        return n;
    }
    //Exercice1.1
    public bool estPair(int valeur)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0)
        {
            return true;

        }
        else
        {
            return false;
        }
    }
    //Exercice1.2
    public void TestEstPair()
    {
        for (int i = 1; i <= 15; i++)
        {
            if (estPair(i))
            {
                Console.WriteLine(i + " est pair");
            }
            else
            {
                Console.WriteLine(i + " est impair");
                
            }
        } 
    }
    
    //Exercice2.1
    public bool EstStrictementPositif(int value)
    { 
        if (value > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    //Exercice2.2

    public void TestEstStrictementPositif()
    {

        for (int i = -10; i <= 10; i++)
        {
            if (EstStrictementPositif(i))
            {
                Console.WriteLine(i + " est strictement positif");
            }
            else
            {
                Console.WriteLine(i + " n'est pas strictement positif");
                
            }
        }
    }
    
    //Exercice3

    public int PosNeg(int nombre1, int nombre2)
    {
        if (nombre1 > 0)
        {
            

        }


        return -1;
    }
    
    //Exercice5

    public bool EstMultiple(int val, int n)
    {


        return false;

    }
    
    //Exercice6
    public int EstPlusGrand(int val1, int val2)
    {
        if (val1 - val2 >= 0)
        {
            return val1;
        }
        else
        {
            return val2;
        }
    }

    //Exercice7
    public bool EstBissextile(int annee)
    {
        if ((annee % 4 == 0 && annee % 100 != 0) && annee % 400 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void TestEstBissextile()
    {
        int n = SaisiePositif();
        if (EstBissextile(n))
        {
            Console.WriteLine(n + " est une année bissextile.");
        }
        else
        {
            Console.WriteLine(n + " n'est pas une année bissextile.");
        }
        
    }
    
    //Exercice8
    public int Factorielle(int value)
    {
        int fact = 1;
        for (int i = 1; i <= value; i++)
        {
            fact *= i;
        }
        return fact;
    }

    public void TestFactorielle()
    {
        int n = SaisiePositif();
        Console.WriteLine(Factorielle(n));
    }

    //Exercice9
    public int Fibonnaci(int n)
    {
        int u_0 = 0;
        int u_1 = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = u_1;
            u_1 = u_1 + u_0;
            u_0 = temp;
        }

        return u_1;

    }

    public void TestFibonnaci()
    { 
        int n;
        Console.WriteLine("Rentrer le rang voulu");
        n = SaisiePositif();
        Console.WriteLine("Résultat : " + Fibonnaci(n));


    }
    

    //Exercice10
    public int NombreOccurences(String s, char c)
    {
        int occurence = 0;
        foreach (var caractere in s)
        {
            if (c == caractere)
            {
                occurence++;
            }
            
        }

        return occurence;
    }
    
    public void TestNombreOccurences()
    {
        Console.WriteLine("Veuillez entrer votre string");
        string chaine = Console.ReadLine();
        Console.WriteLine("Caractère :");
        char car = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Occurence : " + NombreOccurences(chaine,car));
    }
    
    //Exercice11
    public bool estPremier(int value)
    {
        if (value == 1)
        {
            return false;
        }
        
        for (int i = 2; i < value; i++)
        {
            if (value % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    //Exercice12
    public void ListeDesPremiers()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (estPremier(i))
            {
                Console.WriteLine(i + " est premier");
            }
            else
            {
                Console.WriteLine(i + " n'est pas premier");
            }

        }
    }

    //Exercice13
    public int PlusieursPremiers(int debut, int fin, bool affiche)
    {
        int nbrpremiers = 0;
        for (int i = debut; i <= fin; i++)
        {
            if (estPremier(i))
            {
                nbrpremiers++;
                if (affiche)
                {
                    Console.WriteLine(i);
                }
            }
        }
        return nbrpremiers;
    }
    //Exercice14
    public bool EstPresent(string s, char c)
    {
        foreach (char carac in s)
        {
            if (carac == c)
            {
                return true;

            }
            
            
        }

        return false;
    }

    public void TestEstPresent()
    {
        string s;
        char c;
        Console.WriteLine("Veuillez rentrer le caractère à chercher");
        c = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Veuillez rentrer le String à parcourir");
        s = Console.ReadLine();

        if (EstPresent(s, c))
        {
            Console.WriteLine(c + " est contenu dans la chaine de caractère : " + s);
        }
    }
    
    //Exercice15
    public bool EstPalindrome(string s)
    {
        string s1 = "";
        
        for (int i = 0; i < s.Length; i++)
        {
            s1 += s[i];
        }

        if (s1 == s)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void TestEstPalindrome()
    {
        string str;
        Console.WriteLine("Veuillez insérer une chaine de caractère.");
        str = Console.ReadLine();
        if(EstPalindrome(str)) Console.WriteLine(str + " est un palindrome.");
        else Console.WriteLine(str + " n'est pas un palindrome");
    }
    
    //Exercice16

    public bool EstContenu(string s1, string s2)
    {


        return true;


    }
    
    //Exercice17

    public bool Debut(string s1, string s2)
    {
        
        char c1 = s1.ToLower()[0];
        char c2 = s2.ToLower()[0];

        if (c1 == c2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void TestDebut()
    {
        string str1;
        string str2;
        
        Console.WriteLine("Veuillez rentrer la première chaine de caractère.");
        str1 = Console.ReadLine();
        Console.WriteLine("Veuillez rentrer la seconde chaine de caractère.");
        str2 = Console.ReadLine();

        if (Debut(str1, str2))
        {
            Console.WriteLine("Ces deux chaînes de caractères commencent par la même lettres");
        }
        else
        {
            Console.WriteLine("Ces deux chaînes de caractères ne commencent pas par la même lettres");
        }
    }
    
    //Exercice18

    public string SousChaine(string s, int debut, int longueur)
    {
        string substring = "";

        if (debut + longueur <= s.Length)
        {
            for (int i = debut; i < debut + longueur; i++)
            {
                substring += s[i];
            }

            return substring;

        }
        else
        {
            for (int i = debut; i < s.Length; i++)
            {
                substring += s[i];
            }

            return substring;
        }

    }

    public void PartieChaine()
    {
        string str;
        Console.WriteLine("veuillez rentrer une chaine de caractère au moins de taille 10.");
        str = Console.ReadLine();
        while (str.Length < 10)
        {
            Console.WriteLine("Mauvaise saisie.Veuillez rentrer une chaine de caractère au moins de taille 10");
            str = Console.ReadLine();
        }
        Console.WriteLine("La sous chaine : " + str);
    }
    
    //Exercice19
    public bool TailleEgale(string s1, string s2)
    {
        if (s1.Length == s2.Length)
        {
            return true;
        }
        return false;
    }

    public void TailleTailleEgale()
    {
        string str1;
        string str2;
        
        Console.WriteLine("Veuillez rentrer une chaine de caractère.");
        str1 = Console.ReadLine();
        Console.WriteLine("Veuillez rentrer une autre chaine de caractère.");
        str2 = Console.ReadLine();
        if (TailleEgale(str1, str2))
        {
            Console.WriteLine(str1 + " et " + str2 + "sont de même taille.");
        }
        else
        {
            Console.WriteLine(str1 + " et " + str2 + "ne sont pas de même taille.");
        }

    }
    

}