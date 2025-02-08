// Form1.cs - Fereastra principală pentru adăugarea taskurilor
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private List<string> taskuriMarketing = new List<string>();
    private List<string> taskuriWebDesign = new List<string>();

    public Form1()
    {
        InitializeComponent();
    }

    private void btnAdaugaTask_Click(object sender, EventArgs e)
    {
        string task = txtTask.Text;
        string ora = dateTimePicker1.Value.ToShortTimeString();
        string departament = comboBoxDepartament.SelectedItem?.ToString();

        if (!string.IsNullOrEmpty(task) && !string.IsNullOrEmpty(departament))
        {
            if (departament == "Marketing Team")
                taskuriMarketing.Add(task + " - " + ora);
            else if (departament == "Web Design Team")
                taskuriWebDesign.Add(task + " - " + ora);

            txtTask.Clear();
        }
    }

    private void btnVeziTaskuri_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2(taskuriMarketing, taskuriWebDesign);
        form2.Show();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
