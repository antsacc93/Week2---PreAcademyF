using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Week2.EsercitazioneFinale.Entities;

namespace Week2.EsercitazioneFinale
{
    internal static class GestioneTaskAgenda
    {
        public static void StampaTask(ArrayList tasks)
        {
            Console.WriteLine("Task inseriti a sistema");
            foreach(Task task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        public static bool InserisciTask(ArrayList tasks)
        {
            bool inserimentoCompletato = true;
            Task taskDaAggiungere = new Task();
            Console.WriteLine("Inserisci descrizione");
            taskDaAggiungere.Descrizione = Console.ReadLine();
            Console.WriteLine("Inserisci data di scadenza");
            taskDaAggiungere.DataScadenza = VerificaInputDataScadenza();
            Console.WriteLine("Inserisci Priorità");
            taskDaAggiungere.Priorita = Console.ReadLine();
            tasks.Add(taskDaAggiungere);
            return inserimentoCompletato;
        }

        public static DateTime VerificaInputDataScadenza()
        {
            DateTime dataScadenza;
            bool isValid = false;
            do
            {
                Console.WriteLine("Inserire una data di scadenza valida");
                bool conversion = DateTime.TryParse(Console.ReadLine(), out dataScadenza);
                if (!conversion || dataScadenza.Date < DateTime.Today)
                {
                    Console.WriteLine("Data inserita non valida. Riprova");
                    isValid = false;
                }
                else
                {
                    return dataScadenza;
                }
            } while (!isValid);

            return dataScadenza;
        }

        public static void FiltraTask(ArrayList tasks)
        {
            ArrayList taskFiltrati = new ArrayList();
            Console.WriteLine("Inserisci priorità da ricercare");
            string priorita = Console.ReadLine();
            foreach(Task task in tasks)
            {
                if (task.Priorita.Equals(priorita))
                {
                    taskFiltrati.Add(task);
                    //Console.WriteLine(task);
                }
            }
            StampaTask(taskFiltrati);
        }

        public static bool EliminaTask(ArrayList tasks)
        {
            bool elimina = true;
            Console.WriteLine("Inserisci la descrizione del task da cancellare");
            string descrizione = Console.ReadLine();
            Task taskDaCancellare = RicercaTaskPerDescrizione(descrizione, tasks);
            if(taskDaCancellare == null)
            {
                return false;
            }
            else
            {
                tasks.Remove(taskDaCancellare);
            }
            return elimina;
        }

        public static Task RicercaTaskPerDescrizione(string descrizione, ArrayList tasks)
        {
            foreach(Task task in tasks)
            {
                if (task.Descrizione.Equals(descrizione))
                {
                    return task;
                }
            }
            return null;
        }



    }
}
