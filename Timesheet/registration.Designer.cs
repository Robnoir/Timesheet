namespace Timesheet
{
    partial class registration
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.workerName = new System.Windows.Forms.Label();
            this.txt_workerLastname = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancelregistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(3, 24);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(41, 16);
            this.workerName.TabIndex = 0;
            this.workerName.Text = "Pass:";
            this.workerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_workerLastname
            // 
            this.txt_workerLastname.AutoSize = true;
            this.txt_workerLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_workerLastname.Location = new System.Drawing.Point(3, 63);
            this.txt_workerLastname.Name = "txt_workerLastname";
            this.txt_workerLastname.Size = new System.Drawing.Size(74, 16);
            this.txt_workerLastname.TabIndex = 3;
            this.txt_workerLastname.Text = "Datum från:";
            // 
            // txt_address
            // 
            this.txt_address.AutoSize = true;
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(0, 102);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(70, 16);
            this.txt_address.TabIndex = 4;
            this.txt_address.Text = "Datum Till:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(0, 118);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dagtid 07.00 - 15.00",
            "Kväll 15.30 - 00.00",
            "Natt 00.30 - 06.30"});
            this.comboBox1.Location = new System.Drawing.Point(0, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCancelregistration
            // 
            this.btnCancelregistration.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelregistration.ForeColor = System.Drawing.Color.White;
            this.btnCancelregistration.Location = new System.Drawing.Point(100, 200);
            this.btnCancelregistration.Name = "btnCancelregistration";
            this.btnCancelregistration.Size = new System.Drawing.Size(100, 42);
            this.btnCancelregistration.TabIndex = 9;
            this.btnCancelregistration.Text = "Cancel";
            this.btnCancelregistration.UseVisualStyleBackColor = false;
            this.btnCancelregistration.Click += new System.EventHandler(this.button2_Click);
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCancelregistration);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_workerLastname);
            this.Controls.Add(this.workerName);
            this.Name = "registration";
            this.Size = new System.Drawing.Size(605, 456);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Label txt_workerLastname;
        private System.Windows.Forms.Label txt_address;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCancelregistration;
    }
}
