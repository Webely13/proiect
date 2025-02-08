using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderApp
{
    public class ReminderManager
    {
        // Listă privată de remindere
        private readonly List<ReminderModel> reminders;

        // Constructor
        public ReminderManager()
        {
            reminders = new List<ReminderModel>();
        }

        // Adăugarea unui reminder în listă
        public void AddReminder(ReminderModel reminder)
        {
            if (reminder == null)
            {
                throw new ArgumentNullException(nameof(reminder), "Reminder-ul nu poate fi gol.");
            }

            reminders.Add(reminder);
        }

      
    }
}


