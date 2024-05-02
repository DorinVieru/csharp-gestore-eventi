namespace GestoreEventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MILESTONE 1 E 2
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

                // Cancellazione dei posti
                Console.WriteLine("\nDesideri disdire dei posti? (digita si / no)");
                string disdizione = Console.ReadLine().ToLower();
                while (disdizione == "si")
                {
                    Console.Write("Quanti posti vuoi disdire? ");
                    int numPosti = int.Parse(Console.ReadLine());
                    try
                    {
                        evento.DisdiciPosti(numPosti);
                        Console.WriteLine($"Hai disdetto {numPosti} posti. \nPosti prenotati - {evento.PostiPrenotati} \nPosti disponibili - {evento.CapienzaMassima - evento.PostiPrenotati}");
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }

                    Console.WriteLine("\nDesideri disdire ancora dei posti? (digita si / no)");
                    disdizione = Console.ReadLine().ToLower();
                }

                Console.WriteLine("\nOra passa al passaggio successivo! Inizia ad organizzare più eventi!");
            }
 
            // MILESTONE 3 E 4
            {
                // Creazione di un nuovo programma eventi
                Console.Write("\n******************\nInserisci il titolo del tuo programma eventi: ");
                string titoloProgramEvent = Console.ReadLine();

                ProgrammaEventi programEvent = new ProgrammaEventi(titoloProgramEvent);

                // Chiedere all'utente il numero di avebti che vuole aggiungere
                Console.Write("Quanti eventi vuoi aggiungere? ");
                int numAddEvent = int.Parse(Console.ReadLine());

                // Ciclo che mi permettere di inserire un evento per il numero richiesto dall'utente in precedenza
                for (int i = 0; i < numAddEvent; i++)
                {
                    Console.WriteLine($"\n******************\nInserisci i dettagli del {(i + 1)}° evento ");
                    Console.Write("Titolo dell'evento: ");
                    string titolo = Console.ReadLine();
                    Console.Write("Data dell'evento (formato dd/MM/yyyy): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    Console.Write("Capienza massima dell'evento: ");
                    int capienzaMassima = int.Parse(Console.ReadLine());

                    try
                    {
                        Evento evento = new Evento(titolo, data, capienzaMassima);
                        programEvent.AggiungiEvento(evento);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Si è verificato un errore: {ex.Message} L'evento non è stato aggiunto.");
                    }
                }

                // Stampare il numero di eventi presenti
                Console.WriteLine($"\nIl programma eventi '{titoloProgramEvent}' contiene {programEvent.NumEventi()} eventi.");

                // Stampare la lista di eventi
                Console.WriteLine("\n******************\nEcco la lista del tuo programma di eventi:");
                Console.WriteLine(ProgrammaEventi.StampaEventi(programEvent.eventi));

                // Chiedere una data e stampare tutti gli eventi in quella data
                Console.Write("\nInserisci una data per visualizzare gli eventi (formato dd/MM/yyyy): ");
                DateTime dataView = DateTime.Parse(Console.ReadLine());
                // Verifico se ci sono eventi per la data inserita
                bool hasEventsForDate = programEvent.eventi.Any(evento => evento.Data.Date == dataView.Date);
                // Condizione
                if (!hasEventsForDate)
                {
                    Console.WriteLine("Non è presente nessun evento nella data digitata.");
                }
                else
                {
                    List<Evento> eventiInData = programEvent.GetEventData(dataView);
                    Console.WriteLine($"\nGli eventi in data {dataView.ToShortDateString()} sono:");
                    Console.WriteLine(ProgrammaEventi.StampaEventi(eventiInData));
                }

                // Eliminare tutti gli eventi
                programEvent.DelEventi();
                Console.WriteLine("\nTutti gli eventi sono stati eliminati dal programma eventi.");

                Console.WriteLine("\nCiao ciao a presto!");
            }
        }
    }
}
