﻿namespace GestoreEventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inizia a gestire subito i tuoi eventi meravigliosi!");

            // Creazione di un nuovo evento
            Console.Write("\n******************\nInserisci il nome dell'evento (obbligatorio): ");
            string titolo = Console.ReadLine();
            Console.Write("Inserisci la data dell'evento (obbligatorio formato dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Inserisci il numero di posti totali (obbligatorio): ");
            int capienzaMassima = int.Parse(Console.ReadLine());

            Evento evento = new Evento(titolo, data, capienzaMassima);

            // Prenotazione dei posti
            Console.WriteLine("******************\n\nDesideri prenotare dei posti? (digita si / no)");
            string prenotazione = Console.ReadLine().ToLower();
            while (prenotazione == "si")
            {
                Console.Write("Quanti posti vuoi prenotare? ");
                int numPosti = int.Parse(Console.ReadLine());
                try
                {
                    evento.PrenotaPosti(numPosti);
                    Console.WriteLine($"Hai prenotato {numPosti} posti. \nPosti prenotati - {evento.PostiPrenotati} \nPosti disponibili - {evento.CapienzaMassima - evento.PostiPrenotati}");
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }

                Console.WriteLine("\nDesideri prenotare ancora dei posti? (digita si / no)");
                prenotazione = Console.ReadLine().ToLower();
            }

         
        }
    }
}
