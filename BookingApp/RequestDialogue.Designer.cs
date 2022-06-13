namespace BookingApp
{
    partial class RequestDialogue
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
            this.LB = new Wrapper.UListBox();
            this.OkBtn = new Wrapper.UButton();
            this.SuspendLayout();
            // 
            // LB
            // 
            this.LB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB.Font = new System.Drawing.Font("Arial", 12F);
            this.LB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.LB.FormattingEnabled = true;
            this.LB.ItemHeight = 18;
            this.LB.Location = new System.Drawing.Point(12, 12);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(289, 308);
            this.LB.TabIndex = 0;
            this.LB.SelectedIndexChanged += new System.EventHandler(this.LB_SelectedIndexChanged);
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(75)))), ((int)(((byte)(25)))));
            this.OkBtn.Font = new System.Drawing.Font("Arial", 10F);
            this.OkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.OkBtn.Location = new System.Drawing.Point(221, 327);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(80, 30);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "ОК";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // RequestDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 369);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.LB);
            this.Name = "RequestDialogue";
            this.Text = "Выбор начала бизнес-процесса";
            this.ResumeLayout(false);

        }

        #endregion

        private Wrapper.UListBox LB;
        private Wrapper.UButton OkBtn;
    }
}