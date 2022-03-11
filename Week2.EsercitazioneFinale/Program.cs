using System;
using System.Collections;
using Week2.EsercitazioneFinale.Entities;

namespace Week2.EsercitazioneFinale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList tasks = GestioneTaskIO.LeggiTaskDaFile();
            Console.WriteLine("Benvenuto in Task Manager");
            bool quit = false;
            string key;
            do
            {
                Console.WriteLine("Premi 1 - Aggiungi Task");
                Console.WriteLine("Premi 2 - Elimina un task");
                Console.WriteLine("Premi 3 - Visualizza tutti i task");
                Console.WriteLine("Premi 4 - Filtra per importanza");
                Console.WriteLine("Premi q - Esci");

                key = Console.ReadLine();
                
                switch (key)
                {
                    case "1":
                        //TO DO: Metodo per aggiungere un task OK
                        GestioneTaskAgenda.InserisciTask(tasks);
                        
                        break;
                    case "2":
                        //TODO: Elimina Task OK 
                        GestioneTaskAgenda.EliminaTask(tasks);
                        break;
                    case "3":
                        //TODO: Stampa tutti i task OK
                        GestioneTaskAgenda.StampaTask(tasks);
                        break;
                    case "4":
                        //TODO: Filtra per importanza OK
                        GestioneTaskAgenda.FiltraTask(tasks);
                        break;
                    case "q":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Riprovare");
                        break;
                }

            } while (!quit);

            GestioneTaskIO.StampaSuFile(tasks);
        }
    }
}
