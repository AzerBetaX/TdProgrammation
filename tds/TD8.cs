namespace TdProgrammation;

/*
  TD13/14
  On applique les bonnes pratiques de développement:
  - Commentaires.
  - Nomination des variables et méthodes.
  - Indentations.
  - Utilisation des régions pour une meilleure lisibilité.
  - Un seul return par méthode.
 */

public class TD8 : TDManager
{
    protected TD8(string description, Difficulte difficulte) : base(description, difficulte)
    {
        
    }

    
    public class Contact
    {
        private string _phoneNumber;
        private string _lastname;
        private string _firstname;
        private string _category;

        public Contact(string phoneNumber, string lastname, string firstname, string category)
        {
            //Le mot clé "this" est redondant ici : on pourrait l'enlever.
            this._phoneNumber = phoneNumber; 
            this._lastname = lastname;
            this._firstname = firstname;
            this._category = category;
            Console.WriteLine("A new contact has been created !");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Number : {phoneNumber}"  );
            Console.WriteLine($"Firstname : {firstname}"  );
            Console.WriteLine($"Lastname : {lastname}"  );
            Console.WriteLine($"Category : {category}"  );
            Console.WriteLine("----------------------------------");
        }

        #region Getter,Setter,Override methods
            
        //On override la méthode de la classe Object car toute classe en C# hérite de tout le contenu de la classe Object.
        public override string ToString() 
        {
            return "This contact can be display as \n" + 
                   "Number : " + this._phoneNumber +"\n" +
                   "Lastname : " + this._lastname +"\n" +
                   "Firstname : " + this._firstname + "\n" +
                   "Category : " + this._category;
        }

        public string Phonenumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
       
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        

        #endregion

    }
    
    public Contact[] LectureFichier(string nameFile)
    {
        Contact[] tabContact = new Contact[15];
        string[] line = File.ReadAllLines(nameFile); //Tableau dont les éléments les lignes du fichier
        
        for(int i = 0; i < tabContact.Length; i ++){
            
            if (i < line.Length) //On récupère les lignes du fichier
            {
                string[] args = line[i].Split(";"); //La méthode split donne une liste des substrings qui sont séparés par le séparateur (ici ;)
                Contact contact = new Contact(args[0], args[1], args[2], args[3]); //Nouvelle instance 
                tabContact[i] = contact; //On ajoute le nouveau contact à la liste
            }
            else //S'il y a moins de 15 lignes dans le fichier
            {
                tabContact[i] = null; //Valeur null si jamais la fichier contient moins de 15 contacts
            }
        }
        return tabContact;
    }

    public Contact RechercherContact(Contact[] tabContact, string phoneNumber)
    {
        Contact contact = null;
        for (int i = 0; i < tabContact.Length && contact == null; i++)
        {
            if (tabContact[i].Phonenumber == phoneNumber) contact = tabContact[i];
        }
        return contact;
    }

    public void AjoutContact(Contact[] tabContact, string fileName)
    {
        //sous réserve que le fichier existe
        Contact contact = new Contact(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
        bool flag = true;
        for (int i = 0; i < tabContact.Length && flag; i++)
        { 
            if (tabContact[i] == null){ 
                tabContact[i] = contact;
                flag = false;
            }
        }
        string[] line =
            { contact.Phonenumber + ";" + contact.Lastname + ";" + contact.FirstName + ";" + contact.Category };
        File.WriteAllLines(fileName, line);
    }

    public class Produit
    {

        private int _reference;
        private string _label;
        private float _HTprice;
        private int quantity;

        public Produit(int reference, string label, float hTprice, int quantity)
        {
            this._reference = reference;
            this._label = label;
            this._HTprice = hTprice;
            this.quantity = quantity;




        }

        



    }
    
    public static void Main()
    {
        /*
         Exercice1
         string text = "contact.txt";
         On test les méthodes...
        */
        /*
         * De même pour l'exercice 2...
         */
    }
 
    
    
}