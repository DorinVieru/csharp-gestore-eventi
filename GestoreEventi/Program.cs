namespace GestoreEventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inizia a gestire subito i tuoi eventi meravigliosi!");

            // Creazione di un nuovo evento
            Console.Write("Inserisci il nome dell'evento (obbligatorio): ");
            string titolo = Console.ReadLine();
            Console.Write("Inserisci la data dell'evento (obbligatorio formato dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Inserisci il numero di posti totali (obbligatorio): ");
            int capienzaMassima = int.Parse(Console.ReadLine());

            Evento evento = new Evento(titolo, data, capienzaMassima);

            
        }
    }
}
