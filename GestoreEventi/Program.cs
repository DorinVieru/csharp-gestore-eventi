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
                Console.Write("Inserisci il titolo del tuo programma eventi: ");
                string titoloProgrammaEventi = Console.ReadLine();

                ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloProgrammaEventi);

                // Chiedere all'utente il numero di avebti che vuole aggiungere
                Console.Write("Quanti eventi vuoi aggiungere? ");
                int numeroEventiDaAggiungere = int.Parse(Console.ReadLine());

                
            }
        }
    }
}
