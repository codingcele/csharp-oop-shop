using System;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Prodotto Tazza = new Prodotto("Tazza", "Bellissima tazza", 9.99);

            Tazza.PrezzoBase();
            Tazza.PrezzoConIva();
            Tazza.NomeCompleto();
        }
    }

}