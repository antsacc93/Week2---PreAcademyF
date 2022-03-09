using System;
using System.Collections.Generic;
using System.Text;
using Week2.EsercizioAutomobili.Entities;

namespace Week2.EsercizioAutomobili
{
    internal static class VeicoliManagement
    {
        internal static Veicolo InserisciVeicolo()
        {
            Veicolo veicolo = new Veicolo();

            bool success;
            Console.WriteLine("Inserisci marca");
            veicolo.Marca = Console.ReadLine();
            Console.WriteLine("Inserisci i Kilowatt");
            veicolo.Kilowatt = VerificaInputIntero();
            Console.WriteLine("Inserisci anno di immatricolazione");
            veicolo.AnnoImmatricolazione = VerificaInputIntero();
            Console.WriteLine("Inserisci prezzo d'acquisto");
            success = Double.TryParse(Console.ReadLine(), out double costo);
            while (!success)
            {
                Console.WriteLine("Inserisci costo");
                success = Double.TryParse(Console.ReadLine(), out costo);
            }
            veicolo.PrezzoAcquisto = costo;
            Console.WriteLine("Inserisci tipologia");
            string tipo = Console.ReadLine();
            veicolo.Tipologia = tipo;

            return veicolo;
        }

        public static int VerificaInputIntero()
        {
            bool success = Int32.TryParse(Console.ReadLine(), out int value);
            while (!success)
            {
                Console.WriteLine("Inserisci un valore corretto");
                success = Int32.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }

        public static void StampaVeicolo(Veicolo veicolo)
        {
            Console.WriteLine(veicolo);
        }
    }
}
