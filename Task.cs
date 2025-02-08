using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderApp
{
    public class BaseTask
    {
        // Atribute private
        private string mesaj;
        private DateTime dataOra;

        // Constructor
        public BaseTask(string mesaj, DateTime dataOra)
        {
            this.mesaj = mesaj;
            this.dataOra = dataOra;
        }

        // Proprietăți publice pentru acces
        public string Mesaj
        {
            get { return mesaj; }  // Permite doar citirea
            private set { mesaj = value; } // Setarea este privată, accesibilă doar în interiorul clasei
        }

        public DateTime DataOra
        {
            get { return dataOra; }
            private set { dataOra = value; }
        }

        // Metodă publică pentru detalii
        public virtual string Detalii()
        {
            return $"{DataOra:dd/MM/yyyy HH:mm} - {Mesaj}";
        }
    }
}