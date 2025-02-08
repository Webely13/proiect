// Form1.Designer.cs - Design-ul interfeței pentru Form1
partial class Form1
{
    private System.Windows.Forms.TextBox txtTask;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.ComboBox comboBoxDepartament;
    private System.Windows.Forms.Button btnAdaugaTask;
    private System.Windows.Forms.Button btnVeziTaskuri;

    private void InitializeComponent()
    {
            this.txtTask = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDepartament = new System.Windows.Forms.ComboBox();
            this.btnAdaugaTask = new System.Windows.Forms.Button();
            this.btnVeziTaskuri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(450, 168);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(307, 20);
            this.txtTask.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(450, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBoxDepartament
            // 
            this.comboBoxDepartament.Items.AddRange(new object[] {
            "Marketing Team",
            "Web Design Team"});
            this.comboBoxDepartament.Location = new System.Drawing.Point(450, 333);
            this.comboBoxDepartament.Name = "comboBoxDepartament";
            this.comboBoxDepartament.Size = new System.Drawing.Size(307, 21);
            this.comboBoxDepartament.TabIndex = 2;
            // 
            // btnAdaugaTask
            // 
            this.btnAdaugaTask.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdaugaTask.Location = new System.Drawing.Point(450, 423);
            this.btnAdaugaTask.Name = "btnAdaugaTask";
            this.btnAdaugaTask.Size = new System.Drawing.Size(186, 40);
            this.btnAdaugaTask.TabIndex = 3;
            this.btnAdaugaTask.Text = "Adaugă Task";
            this.btnAdaugaTask.Click += new System.EventHandler(this.btnAdaugaTask_Click);
            // 
            // btnVeziTaskuri
            // 
            this.btnVeziTaskuri.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeziTaskuri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVeziTaskuri.Location = new System.Drawing.Point(113, 423);
            this.btnVeziTaskuri.Name = "btnVeziTaskuri";
            this.btnVeziTaskuri.Size = new System.Drawing.Size(186, 40);
            this.btnVeziTaskuri.TabIndex = 4;
            this.btnVeziTaskuri.Text = "Vezi Taskuri";
            this.btnVeziTaskuri.Click += new System.EventHandler(this.btnVeziTaskuri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ReminderApp.Properties.Resources.icon_webely;
            this.pictureBox1.Location = new System.Drawing.Point(305, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 82);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(40, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 40);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Introdu un task";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(40, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 40);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Data si ora scadenta";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox3.Location = new System.Drawing.Point(40, 312);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(259, 40);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Cui i se adreseaza";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(796, 515);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxDepartament);
            this.Controls.Add(this.btnAdaugaTask);
            this.Controls.Add(this.btnVeziTaskuri);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
}
