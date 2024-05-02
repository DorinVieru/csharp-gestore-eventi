using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        // Attributi classe evento
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int postiPrenotati;

        // Costruttore
        public Evento(string titolo, DateTime data, int capienzaMassima)
        {
            this.Titolo = titolo;
            this.Data = data;
            this.CapienzaMassima = capienzaMassima;
            this.PostiPrenotati = 0; 
        }

        // Gestione dei getter, dei setter e degli errori
        public string Titolo
        {
            get { return titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Deve esserci un titolo, non è possibile lasciare vuoto questo campo.");
                titolo = value;
            }
        }

        public DateTime Data
        {
            get { return data; }
            set
            {
                if (value < DateTime.Now)
                    throw new ArgumentOutOfRangeException("La data inserita non può essere precedente alla data corrente.");
                data = value;
            }
        }

        public int CapienzaMassima
        {
            get { return capienzaMassima; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("La capienza massima deve essere un numero positivo (maggiore di 0).");
                capienzaMassima = value;
            }
        }

        public int PostiPrenotati
        {
            get { return postiPrenotati; }
            private set
            {
                if (value < 0 || value > CapienzaMassima)
                    throw new ArgumentOutOfRangeException("Il numero di posti prenotati deve essere compreso tra 0 (numero positivo) e la capienza massima disponibile.");
                postiPrenotati = value;
            }
        }
    }
}
