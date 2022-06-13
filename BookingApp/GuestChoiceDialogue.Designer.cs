namespace BookingApp
{
    partial class GuestChoiceDialogue
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
            this.OkBtn = new Wrapper.UButton();
            this.CancelBtn = new Wrapper.UButton();
            this.StateListBox = new Wrapper.UListBox();
            this.RenewBtn = new Wrapper.UButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTB = new Wrapper.UTextBox();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(75)))), ((int)(((byte)(25)))));
            this.OkBtn.Font = new System.Drawing.Font("Arial", 10F);
            this.OkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.OkBtn.Location = new System.Drawing.Point(205, 415);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(80, 30);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "ОК";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(75)))), ((int)(((byte)(25)))));
            this.CancelBtn.Font = new System.Drawing.Font("Arial", 10F);
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.CancelBtn.Location = new System.Drawing.Point(291, 415);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(80, 30);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // StateListBox
            // 
            this.StateListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.StateListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StateListBox.Font = new System.Drawing.Font("Arial", 10F);
            this.StateListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.StateListBox.FormattingEnabled = true;
            this.StateListBox.ItemHeight = 16;
            this.StateListBox.Location = new System.Drawing.Point(12, 55);
            this.StateListBox.Name = "StateListBox";
            this.StateListBox.Size = new System.Drawing.Size(354, 338);
            this.StateListBox.TabIndex = 2;
            // 
            // RenewBtn
            // 
            this.RenewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(75)))), ((int)(((byte)(25)))));
            this.RenewBtn.Font = new System.Drawing.Font("Arial", 10F);
            this.RenewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.RenewBtn.Location = new System.Drawing.Point(13, 415);
            this.RenewBtn.Name = "RenewBtn";
            this.RenewBtn.Size = new System.Drawing.Size(90, 30);
            this.RenewBtn.TabIndex = 7;
            this.RenewBtn.Text = "Обновить";
            this.RenewBtn.UseVisualStyleBackColor = false;
            this.RenewBtn.Click += new System.EventHandler(this.RenewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск:";
            // 
            // SearchTB
            // 
            this.SearchTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.SearchTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.SearchTB.Location = new System.Drawing.Point(62, 20);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(304, 20);
            this.SearchTB.TabIndex = 6;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            // 
            // GuestChoiceDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.RenewBtn);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.StateListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GuestChoiceDialogue";
            this.Text = "Выберите состояние";
            this.Load += new System.EventHandler(this.StateChoiceDialogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wrapper.UListBox StateListBox;
        private Wrapper.UButton CancelBtn;
        private Wrapper.UButton OkBtn;
        private Wrapper.UButton RenewBtn;
        private System.Windows.Forms.Label label1;
        private Wrapper.UTextBox SearchTB;
    }
}