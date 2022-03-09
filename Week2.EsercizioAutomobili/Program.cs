using System;
using Week2.EsercizioAutomobili.Entities;

namespace Week2.EsercizioAutomobili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veicolo veicoloDaAggiungere = new Veicolo();
            bool continua = true;
            while (continua)
            {
                int scelta = SchermoMenu();

                switch (scelta)
                {
                    case 1:
                       veicoloDaAggiungere = VeicoliManagement.InserisciVeicolo();
                        break;
                    case 2:
                        VeicoliManagement.StampaVeicolo(veicoloDaAggiungere);
                        break;
                    default: //un numero diverso da 0
                        continua = false;
                        Console.WriteLine("Arrivederci");
                        break;
                }
            }

        }

        public static int SchermoMenu()
        {
            Console.WriteLine("1. Inserisci veicolo");
            Console.WriteLine("2. Stampa veicolo");
            Console.WriteLine("Qualsiasi altro valore per uscire");
            Console.Write("Scelta: >");
            Int32.TryParse(Console.ReadLine(), out int scelta);
            return scelta;
        }
    }
}
