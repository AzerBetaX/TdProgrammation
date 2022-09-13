namespace TdProgrammation;

public class TDManager
{
    /*
     * Classe mère des TD
     */
    
    private String nom;
    private String description;
    private Difficulte _difficulte;

    protected TDManager(String description,Difficulte difficulte)
    {
        this.nom = this.GetType().Name;
        this.description = description;
        this._difficulte = difficulte;
        Console.WriteLine("Un Td vient d'être consulté son nom est " + nom); //Affiche le nom du TD
        Console.WriteLine(description);
        Console.WriteLine("La difficulté de ce TD est : " + difficulte.ToString());

    }

    public int nombreExercice()
    {
        return this.GetType().GetMethods().Length;
        

        return 0;
    }





}