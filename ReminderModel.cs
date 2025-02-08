using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderApp
{
    public class ReminderModel : BaseTask
    {
        public int Id { get; private set; } // Încapsulare prin folosirea unui setter privat

        public ReminderModel(int id, string mesaj, DateTime dataOra)
            : base(mesaj, dataOra) // Apelăm constructorul clasei de bază
        {
           this.Id = id;
        }
        public ReminderModel() : base("", DateTime.MinValue) { }

        // Suprascriem metoda `Detalii` pentru a adăuga informații suplimentare
        public override string Detalii()
        {
            return $"[Reminder #{Id}] {base.Detalii()}";
        }

        // Suprascriem `ToString` pentru a afișa detalii personalizate
        public override string ToString()
        {
            return Detalii();
        }
    }
}

