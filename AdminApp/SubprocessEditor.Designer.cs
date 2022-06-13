namespace AdminApp
{
    partial class SubprocessEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.uTextBox1 = new Wrapper.UTextBox();
            this.uTextBox2 = new Wrapper.UTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uChooserLink1 = new Wrapper.UChooserLink();
            this.uButton1 = new Wrapper.UButton();
            this.uButton2 = new Wrapper.UButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "НАЗВАНИЕ ПОДПРОЦЕССА: ";
            // 
            // uTextBox1
            // 
            this.uTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.uTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.uTextBox1.Location = new System.Drawing.Point(16, 32);
            this.uTextBox1.Name = "uTextBox1";
            this.uTextBox1.Size = new System.Drawing.Size(187, 23);
            this.uTextBox1.TabIndex = 1;
            this.uTextBox1.Text = "Регистрация заявки";
            // 
            // uTextBox2
            // 
            this.uTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.uTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uTextBox2.Enabled = false;
            this.uTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.uTextBox2.Location = new System.Drawing.Point(16, 89);
            this.uTextBox2.Name = "uTextBox2";
            this.uTextBox2.Size = new System.Drawing.Size(187, 23);
            this.uTextBox2.TabIndex = 3;
            this.uTextBox2.Text = "Бронирование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "УЧАСТИЕ В ПРОЦЕССЕ:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 174);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ТРЕБОВАНИЯ К ПОДПРОЦЕССУ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(257, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ВХОДНОЙ ПОДПРОЦЕСС:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(484, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "ВЫХОДЫЕ ПОДПРОЦЕССЫ:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(487, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 95);
            this.panel2.TabIndex = 8;
            // 
            // uChooserLink1
            // 
            this.uChooserLink1.AutoSize = true;
            this.uChooserLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uChooserLink1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline);
            this.uChooserLink1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.uChooserLink1.Location = new System.Drawing.Point(257, 37);
            this.uChooserLink1.Name = "uChooserLink1";
            this.uChooserLink1.Size = new System.Drawing.Size(74, 18);
            this.uChooserLink1.TabIndex = 9;
            this.uChooserLink1.Text = "Выбрать";
            // 
            // uButton1
            // 
            this.uButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(75)))), ((int)(((byte)(25)))));
            this.uButton1.Font = new System.Drawing.Font("Arial", 10F);
            this.uButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.uButton1.Location = new System.Drawing.Point(501, 363);
            this.uButton1.Name = "uButton1";
            this.uButton1.Size = new System.Drawing.Size(80, 30);
            this.uButton1.TabIndex = 10;
            this.uButton1.Text = "ОК";
            this.uButton1.UseVisualStyleBackColor = false;
            // 
            // uButton2
            // 
            this.uButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(75)))), ((int)(((byte)(25)))));
            this.uButton2.Font = new System.Drawing.Font("Arial", 10F);
            this.uButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.uButton2.Location = new System.Drawing.Point(596, 363);
            this.uButton2.Name = "uButton2";
            this.uButton2.Size = new System.Drawing.Size(79, 30);
            this.uButton2.TabIndex = 11;
            this.uButton2.Text = "Отмена";
            this.uButton2.UseVisualStyleBackColor = false;
            // 
            // SubprocessEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 398);
            this.Controls.Add(this.uButton2);
            this.Controls.Add(this.uButton1);
            this.Controls.Add(this.uChooserLink1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uTextBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SubprocessEditor";
            this.Text = "Создание подпроцесса";
            this.Load += new System.EventHandler(this.SubprocessEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Wrapper.UTextBox uTextBox1;
        private Wrapper.UTextBox uTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private Wrapper.UChooserLink uChooserLink1;
        private Wrapper.UButton uButton1;
        private Wrapper.UButton uButton2;
    }
}