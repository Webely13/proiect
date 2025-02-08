using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReminderApp
{
    public class MainForm : Form
    {
        private Button btnViewTasks;
        private Button btnAddTask;
        private List<string> taskList = new List<string>();
        private PictureBox logoPictureBox;  // Adăugăm PictureBox pentru logo

        public MainForm()
        {
            // Setăm fundalul și stilul
            this.Text = "Reminder App";
            this.Size = new System.Drawing.Size(400, 400);  // Mărim dimensiunea ferestrei
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.Black;
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF4A16");

            // Adăugăm PictureBox pentru logo
            logoPictureBox = new PictureBox
            {
                Image = Properties.Resources.webely.png,  // Folosim resursa pentru logo (fișierul .png)
                SizeMode = PictureBoxSizeMode.Zoom,  // Se ajustează imaginea la dimensiunea controlului
                Dock = DockStyle.Top,  // Împingem imaginea în partea de sus
                Height = 100  // Setăm înălțimea imaginii
            };

            // Creăm butonul "Vezi Taskuri"
            btnViewTasks = new Button
            {
                Text = "Vezi Taskuri",
                Size = new System.Drawing.Size(150, 50),
                Location = new System.Drawing.Point(120, 160),
                BackColor = System.Drawing.Color.Black,
                ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF4A16"),
                FlatStyle = FlatStyle.Flat
            };
            btnViewTasks.Click += BtnViewTasks_Click;

            // Creăm butonul "Setează un Task Nou"
            btnAddTask = new Button
            {
                Text = "Setează un Task Nou",
                Size = new System.Drawing.Size(150, 50),
                Location = new System.Drawing.Point(120, 220),
                BackColor = System.Drawing.Color.Black,
                ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF4A16"),
                FlatStyle = FlatStyle.Flat
            };
            btnAddTask.Click += BtnAddTask_Click;

            // Adăugăm controalele în fereastră
            this.Controls.Add(logoPictureBox);  // Adăugăm logo-ul mai întâi
            this.Controls.Add(btnViewTasks);
            this.Controls.Add(btnAddTask);
        }

        private void BtnViewTasks_Click(object sender, EventArgs e)
        {
            if (taskList.Count == 0)
            {
                MessageBox.Show("Nu există taskuri de afișat.", "Info");
            }
            else
            {
                TaskListForm taskListForm = new TaskListForm(taskList);
                taskListForm.ShowDialog();
            }
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            if (taskForm.ShowDialog() == DialogResult.OK)
            {
                string newTask = $"Task: {taskForm.TaskName}, Data: {taskForm.DueDate.ToShortDateString()}, Cui: {taskForm.AssignedTo}, Secțiune: {taskForm.Section}";
                taskList.Add(newTask);
                MessageBox.Show("Task adăugat cu succes!", "Info");
            }
        }
    }
}