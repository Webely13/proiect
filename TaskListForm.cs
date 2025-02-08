using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReminderApp
{
    public class TaskListForm : Form
    {
        private ListView listViewWebDesign;
        private ListView listViewDigitalMarketing;
        private List<string> webDesignTasks;
        private List<string> digitalMarketingTasks;

        private Label lblWebDesign;
        private Label lblDigitalMarketing;

        public TaskListForm(List<string> tasks)
        {
            this.Text = "Lista Taskuri";
            this.Size = new System.Drawing.Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.Black;
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF4A16");

            // Creăm eticheta pentru Web Design
            lblWebDesign = new Label
            {
                Text = "Taskuri Web Design",
                ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF4A16"),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Height = 30,
                Dock = DockStyle.Top
            };

            // Creăm eticheta pentru Digital Marketing
            lblDigitalMarketing = new Label
            {
                Text = "Taskuri Digital Marketing",
                ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF4A16"),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Height = 30,
                Dock = DockStyle.Top
            };

            // Creăm ListView pentru Web Design
            listViewWebDesign = new ListView
            {
                Dock = DockStyle.Top,
                Height = 150, // Înălțimea pentru lista Web Design
                View = View.List,
                FullRowSelect = true
            };

            // Creăm ListView pentru Digital Marketing
            listViewDigitalMarketing = new ListView
            {
                Dock = DockStyle.Top,
                Height = 150, // Înălțimea pentru lista Digital Marketing
                View = View.List,
                FullRowSelect = true
            };

            // Inițializăm listele de taskuri pentru fiecare secțiune
            webDesignTasks = new List<string>();
            digitalMarketingTasks = new List<string>();

            // Împărțim taskurile între cele două secțiuni
            foreach (var task in tasks)
            {
                if (task.Contains("Web Design"))
                {
                    webDesignTasks.Add(task);
                }
                else if (task.Contains("Digital Marketing"))
                {
                    digitalMarketingTasks.Add(task);
                }
            }

            // Adăugăm taskurile la fiecare secțiune
            foreach (var task in webDesignTasks)
            {
                listViewWebDesign.Items.Add(task);
            }

            foreach (var task in digitalMarketingTasks)
            {
                listViewDigitalMarketing.Items.Add(task);
            }

            // Adăugăm titlurile și listele în fereastră (ordinea corectă)
            this.Controls.Add(listViewWebDesign); // Adăugăm lista de Web Design prima
            this.Controls.Add(lblWebDesign); // Adăugăm titlul Web Design după ListView pentru a fi plasat deasupra
            this.Controls.Add(listViewDigitalMarketing); // Adăugăm lista de Digital Marketing
            this.Controls.Add(lblDigitalMarketing); // Adăugăm titlul Digital Marketing după ListView pentru a fi plasat deasupra
        }
    }
}