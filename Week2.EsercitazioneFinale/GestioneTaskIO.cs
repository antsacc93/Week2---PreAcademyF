using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Week2.EsercitazioneFinale.Entities;

namespace Week2.EsercitazioneFinale
{
    internal static class GestioneTaskIO
    {
        public static string PathText { get; } = Path.Combine(Environment
            .GetFolderPath(Environment.SpecialFolder.Desktop), "task.txt");

        public static void StampaSuFile(ArrayList tasks)
        {

            
            using (StreamWriter sw = File.CreateText(PathText))
            {
                foreach (Task task in tasks)
                {
                    sw.WriteLine(task);
                }
            }
        }

        public static ArrayList LeggiTaskDaFile()
        {
            
            ArrayList tasks = new ArrayList();


            using (StreamReader reader = File.OpenText(PathText))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    
                    string[] taskData = line.Split("-");

                    Task task = new Task()
                    {
                        Descrizione = taskData[0].Trim(),
                        DataScadenza = DateTime.Parse(taskData[1].Trim()),
                        Priorita = taskData[2].Trim()
                    };

                    tasks.Add(task);
                    line = reader.ReadLine();
                }
            }
            return tasks;
        }
    }
}
