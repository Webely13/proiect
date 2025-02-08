// Form2.Designer.cs - Design-ul interfeței pentru Form2
partial class Form2
{
    private System.Windows.Forms.ListBox listBoxMarketing;
    private System.Windows.Forms.ListBox listBoxWebDesign;

    private void InitializeComponent()
    {
            this.listBoxMarketing = new System.Windows.Forms.ListBox();
            this.listBoxWebDesign = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMarketing
            // 
            this.listBoxMarketing.BackColor = System.Drawing.Color.Black;
            this.listBoxMarketing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMarketing.ForeColor = System.Drawing.Color.White;
            this.listBoxMarketing.ItemHeight = 24;
            this.listBoxMarketing.Location = new System.Drawing.Point(352, 117);
            this.listBoxMarketing.Name = "listBoxMarketing";
            this.listBoxMarketing.Size = new System.Drawing.Size(267, 292);
            this.listBoxMarketing.TabIndex = 0;
            // 
            // listBoxWebDesign
            // 
            this.listBoxWebDesign.BackColor = System.Drawing.Color.Black;
            this.listBoxWebDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWebDesign.ForeColor = System.Drawing.Color.White;
            this.listBoxWebDesign.ItemHeight = 24;
            this.listBoxWebDesign.Location = new System.Drawing.Point(12, 117);
            this.listBoxWebDesign.Name = "listBoxWebDesign";
            this.listBoxWebDesign.Size = new System.Drawing.Size(267, 292);
            this.listBoxWebDesign.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReminderApp.Properties.Resources.icon_webely;
            this.pictureBox1.Location = new System.Drawing.Point(240, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 82);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(399, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Marketing Task";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(73, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 24);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Web Task";
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(631, 434);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxMarketing);
            this.Controls.Add(this.listBoxWebDesign);
            this.Name = "Form2";
            this.Text = "a";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
}
