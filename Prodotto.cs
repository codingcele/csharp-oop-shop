using System;

namespace Program
{
    internal class Prodotto
    {

        public int codice { get; }
        public string nome { get; set; }
        public string descrizione { get; set; }
        public double prezzo { get; set; }
        public double iva { get; set; }


        public Prodotto(string nome, string descrizione, double prezzo, double iva = 0.22)
        {
            Random random = new Random();
            this.codice = random.Next(100000, 1000000);
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;

            Console.WriteLine("ciao");
        }

        public double PrezzoBase()
        {
            Console.WriteLine("Il prezzo base del prodotto è: " + this.prezzo.ToString());
            return this.prezzo;
        }

        public double PrezzoConIva()
        {
            double prezzoConIva = this.prezzo * (1 + this.iva);
            Console.WriteLine("Il prezzo con Iva del prodotto è: " + prezzoConIva.ToString());
            return prezzoConIva;
        }

        public string NomeCompleto()
        {
            string nomeCompleto = this.codice.ToString() + this.nome;
            Console.WriteLine("Il nome completo del prodotto è: " + nomeCompleto);
            return nomeCompleto;
        }
    }
     
}
