using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        // Attributi per ProgrammaEventi
        private string titolo;
        public List<Evento> eventi;

        // Costruttore
        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            this.eventi = new List<Evento>();
        }

        // Metodo per aggiungere un evento alla lista
        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        // Metodo per avere gli eventi in una certa data
        public List<Evento> GetEventData(DateTime data)
        {
            return eventi.FindAll(evento => evento.Data.Date == data.Date);
        }

        // Metodo statico per stampare la lista di eventi
        public static string StampaEventi(List<Evento> eventi)
        {
            StringBuilder listEvent = new StringBuilder();
            foreach (var evento in eventi)
            {
                listEvent.AppendLine(evento.ToString());
            }
            return listEvent.ToString();
        }

        // Metodo per ottenere il numero di eventi
        public int NumEventi()
        {
            return eventi.Count;
        }

        // Metodo per svuotare la lista di eventi
        public void DelEventi()
        {
            eventi.Clear();
        }

        // Metodo che mostra il titolo del programma e tutti gli eventi aggiunti alla lista
        public string MostraTitoloEventi()
        {
            return $"Titolo: {titolo}\n{StampaEventi(eventi)}";
        }
    }
}
