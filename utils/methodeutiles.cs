using System.ComponentModel.Design.Serialization;
using System.IO.Compression;

namespace ClassLibrary1.utils;

public class methodeutiles
{
    public bool estpositif(int n,bool strictement)
    { 
        if (n > 0 && strictement)
        {
            Console.WriteLine(n + " est strictement positif.");
            return true; 
        }

        if (n >= 0 && !strictement)
        {
            Console.WriteLine("");
            return true;

        }

        return false;

    }
    


}