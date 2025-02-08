// Form2.cs - Fereastra pentru vizualizarea taskurilor
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class Form2 : Form
{
    public Form2(List<string> marketingTasks, List<string> webDesignTasks)
    {
        InitializeComponent();
        LoadTasks(marketingTasks, webDesignTasks);
    }

    private void LoadTasks(List<string> marketingTasks, List<string> webDesignTasks)
    {
        foreach (var task in marketingTasks)
        {
            listBoxMarketing.Items.Add(task);
        }
        foreach (var task in webDesignTasks)
        {
            listBoxWebDesign.Items.Add(task);
        }
    }
}