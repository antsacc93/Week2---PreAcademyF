using System;

namespace Week2.GestioneCopisteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua;
            do
            {
                continua = GestoreCopisteria.Menu();
            } while (continua);
        }
    }
}
