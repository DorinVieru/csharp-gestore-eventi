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
        private List<Evento> eventi;

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

       
    }
}
