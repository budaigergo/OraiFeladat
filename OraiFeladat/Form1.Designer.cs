namespace OraiFeladat
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.richTextBox_szoveg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(379, 75);
            this.textBox_Nev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(148, 26);
            this.textBox_Nev.TabIndex = 0;
            // 
            // richTextBox_szoveg
            // 
            this.richTextBox_szoveg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_szoveg.Location = new System.Drawing.Point(0, 274);
            this.richTextBox_szoveg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_szoveg.Name = "richTextBox_szoveg";
            this.richTextBox_szoveg.Size = new System.Drawing.Size(1045, 282);
            this.richTextBox_szoveg.TabIndex = 1;
            this.richTextBox_szoveg.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nev";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 132);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(746, 24);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(196, 93);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Mentés";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(746, 136);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(196, 103);
            this.button_Open.TabIndex = 5;
            this.button_Open.Text = "Megnyitás";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_szoveg);
            this.Controls.Add(this.textBox_Nev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.RichTextBox richTextBox_szoveg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
    }
}

