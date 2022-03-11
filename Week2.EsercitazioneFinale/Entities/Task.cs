using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.EsercitazioneFinale.Entities
{
    internal class Task
    {
        public string Descrizione { get; set; }
        public DateTime DataScadenza { get; set; }
        public string Priorita { get; set; }

        public override string ToString()
        {
            return $"{Descrizione} - {DataScadenza.ToShortDateString()} - {Priorita}";
        }
    }
}
