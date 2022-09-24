namespace TdProgrammation;

public class TD7
{

    public class Position
    {

        private int x;
        private int y;
        
        public Position(int x,int y)
        {
            if (x < 0)
            {
                this.x = -x;
                Console.WriteLine("Autocorrection...");
                
            }
            else
            {
                this.x = x;

            }
            
            if (y < 0)
            {
                this.y = -y;
                Console.WriteLine("Autocorrection...");
                
            }
            else
            {
                this.y = y;

            }
        }

        public string toString()
        {
            return "La position se situe en x : " + this.x + " et y : " + this.y;
        }

        public bool EstEgale(Position pos)
        {
            return pos.x == this.x && pos.y == this.y;

        }
        
        
        
        
        
        
        
        
    }
    
    public class Labyrinthe
    {

        private int[,] matrice;
        private int nbLignes;
        private int nbColonnes;

        private Position depart;
        private Position arrivee;



    }

    public class Personnage
    {

        private Labyrinthe laby;

        public Personnage(Labyrinthe laby)
        {
            this.laby = laby;
        }

        public bool EstArrivee()
        {
            return false;





        }



    }
    
    
    
    
}