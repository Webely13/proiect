using System;
using System.Windows.Forms;

namespace ReminderApp
{
    public class TaskForm : Form
    {
        private Label lblTaskName;
        private TextBox txtTaskName;
        private Label lblDueDate;
        private DateTimePicker dtpDueDate;
        private Label lblAssignedTo;
        private ComboBox cmbAssignedTo;
        private Label lblSection;
        private ComboBox cmbSection;
        private Button btnSaveTask;

        public string TaskName { get; private set; }
        public DateTime DueDate { get; private set; }
        public string AssignedTo { get; private set; }
        public string Section { get; private set; }

        public TaskForm()
        {
            // Configurăm fereastra
            this.Text = "Task Nou";
            this.Size = new System.Drawing.Size(350, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.Black;
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF4A16");

            // Etichetă pentru numele taskului
            lblTaskName = new Label();
            lblTaskName.Text = "Nume Task:";
            lblTaskName.Location = new System.Drawing.Point(10, 20);

            // TextBox pentru numele taskului
            txtTaskName = new TextBox();
            txtTaskName.Location = new System.Drawing.Point(120, 20);
            txtTaskName.Size = new System.Drawing.Size(200, 22);

            // Etichetă pentru data limită
            lblDueDate = new Label();
            lblDueDate.Text = "Data limită:";
            lblDueDate.Location = new System.Drawing.Point(10, 60);

            // DateTimePicker pentru data limită
            dtpDueDate = new DateTimePicker();
            dtpDueDate.Location = new System.Drawing.Point(120, 60);
            dtpDueDate.Size = new System.Drawing.Size(200, 22);

            // Etichetă pentru destinatari
            lblAssignedTo = new Label();
            lblAssignedTo.Text = "Cui se adresează:";
            lblAssignedTo.Location = new System.Drawing.Point(10, 100);

            // ComboBox pentru destinatari
            cmbAssignedTo = new ComboBox();
            cmbAssignedTo.Location = new System.Drawing.Point(120, 100);
            cmbAssignedTo.Size = new System.Drawing.Size(200, 22);
            cmbAssignedTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssignedTo.Items.AddRange(new string[] { "Echipa Marketing", "Departamentul IT", "Manager", "Resurse Umane" });

            // Etichetă pentru secțiune
            lblSection = new Label();
            lblSection.Text = "Secțiune:";
            lblSection.Location = new System.Drawing.Point(10, 140);

            // ComboBox pentru secțiune (Web Design sau Digital Marketing)
            cmbSection = new ComboBox();
            cmbSection.Location = new System.Drawing.Point(120, 140);
            cmbSection.Size = new System.Drawing.Size(200, 22);
            cmbSection.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSection.Items.AddRange(new string[] { "Web Design", "Digital Marketing" });

            // Buton pentru salvarea taskului
            btnSaveTask = new Button();
            btnSaveTask.Text = "Salvează Task";
            btnSaveTask.Location = new System.Drawing.Point(100, 180);
            btnSaveTask.Size = new System.Drawing.Size(120, 30);
            btnSaveTask.Click += BtnSaveTask_Click;

            // Adăugăm controalele în fereastră
            this.Controls.Add(lblTaskName);
            this.Controls.Add(txtTaskName);
            this.Controls.Add(lblDueDate);
            this.Controls.Add(dtpDueDate);
            this.Controls.Add(lblAssignedTo);
            this.Controls.Add(cmbAssignedTo);
            this.Controls.Add(lblSection);
            this.Controls.Add(cmbSection);
            this.Controls.Add(btnSaveTask);
        }

        private void BtnSaveTask_Click(object sender, EventArgs e)
        {
            TaskName = txtTaskName.Text;
            DueDate = dtpDueDate.Value;
            AssignedTo = cmbAssignedTo.SelectedItem?.ToString();
            Section = cmbSection.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(TaskName))
            {
                MessageBox.Show("Te rog completează numele taskului.", "Eroare");
                return;
            }

            if (string.IsNullOrWhiteSpace(AssignedTo))
            {
                MessageBox.Show("Te rog selectează cui i se adresează taskul.", "Eroare");
                return;
            }

            if (string.IsNullOrWhiteSpace(Section))
            {
                MessageBox.Show("Te rog selectează secțiunea taskului.", "Eroare");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}