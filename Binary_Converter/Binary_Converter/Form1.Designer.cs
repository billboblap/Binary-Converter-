namespace Binary_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtDenary = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtBinary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn2Binary = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn2Denary = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Hex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Octaltxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Usless = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDenary
            // 
            this.TxtDenary.Location = new System.Drawing.Point(12, 12);
            this.TxtDenary.Name = "TxtDenary";
            this.TxtDenary.Size = new System.Drawing.Size(182, 20);
            this.TxtDenary.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Denary";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // TxtBinary
            // 
            this.TxtBinary.Location = new System.Drawing.Point(12, 56);
            this.TxtBinary.Name = "TxtBinary";
            this.TxtBinary.Size = new System.Drawing.Size(182, 20);
            this.TxtBinary.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Binary";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btn2Binary
            // 
            this.Btn2Binary.Location = new System.Drawing.Point(203, 218);
            this.Btn2Binary.Name = "Btn2Binary";
            this.Btn2Binary.Size = new System.Drawing.Size(182, 26);
            this.Btn2Binary.TabIndex = 4;
            this.Btn2Binary.Text = "Convert_Binary";
            this.Btn2Binary.UseVisualStyleBackColor = true;
            this.Btn2Binary.Click += new System.EventHandler(this.Btn2Binary_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bill Barg 2020";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Btn2Denary
            // 
            this.Btn2Denary.Location = new System.Drawing.Point(15, 218);
            this.Btn2Denary.Name = "Btn2Denary";
            this.Btn2Denary.Size = new System.Drawing.Size(182, 26);
            this.Btn2Denary.TabIndex = 6;
            this.Btn2Denary.Text = "Convert_Denary";
            this.Btn2Denary.UseVisualStyleBackColor = true;
            this.Btn2Denary.Click += new System.EventHandler(this.Btn2Denary_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ツ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_Hex
            // 
            this.txt_Hex.Location = new System.Drawing.Point(200, 12);
            this.txt_Hex.Name = "txt_Hex";
            this.txt_Hex.Size = new System.Drawing.Size(182, 20);
            this.txt_Hex.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hexadecimal";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 185);
            this.progressBar1.Maximum = 80;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(369, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // Octaltxt
            // 
            this.Octaltxt.Location = new System.Drawing.Point(201, 55);
            this.Octaltxt.Name = "Octaltxt";
            this.Octaltxt.Size = new System.Drawing.Size(181, 20);
            this.Octaltxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Octal";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(15, 278);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(366, 23);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear All";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(387, 229);
            this.trackBar1.Maximum = 100000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(197, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Usless
            // 
            this.Usless.Location = new System.Drawing.Point(387, 280);
            this.Usless.Name = "Usless";
            this.Usless.Size = new System.Drawing.Size(197, 20);
            this.Usless.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(391, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "ClickMe!";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Convert_Hex";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(394, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AcceptButton = this.Btn2Binary;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(630, 315);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Usless);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Octaltxt);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Hex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn2Denary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn2Binary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBinary);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtDenary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDenary;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TxtBinary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn2Binary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn2Denary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Hex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox Octaltxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox Usless;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

