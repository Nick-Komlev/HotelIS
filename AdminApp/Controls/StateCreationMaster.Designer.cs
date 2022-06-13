namespace AdminApp
{
    partial class StateCreationMaster
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfomationPanel = new System.Windows.Forms.Panel();
            this.StateNameTB = new Wrapper.UTextBox();
            this.StateNameLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.StatePanel = new System.Windows.Forms.Panel();
            this.StateTablePanel = new System.Windows.Forms.Panel();
            this.StateHeaderPanel = new System.Windows.Forms.Panel();
            this.StateHeaderLabel = new System.Windows.Forms.Label();
            this.ConfirmationPanel = new System.Windows.Forms.Panel();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.RenewBtn = new Wrapper.UButton();
            this.InfomationPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.StatePanel.SuspendLayout();
            this.StateHeaderPanel.SuspendLayout();
            this.ConfirmationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfomationPanel
            // 
            this.InfomationPanel.Controls.Add(this.StateNameTB);
            this.InfomationPanel.Controls.Add(this.StateNameLabel);
            this.InfomationPanel.Location = new System.Drawing.Point(4, 72);
            this.InfomationPanel.Name = "InfomationPanel";
            this.InfomationPanel.Size = new System.Drawing.Size(443, 78);
            this.InfomationPanel.TabIndex = 0;
            // 
            // StateNameTB
            // 
            this.StateNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.StateNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StateNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.StateNameTB.Location = new System.Drawing.Point(27, 37);
            this.StateNameTB.Name = "StateNameTB";
            this.StateNameTB.Size = new System.Drawing.Size(211, 23);
            this.StateNameTB.TabIndex = 6;
            // 
            // StateNameLabel
            // 
            this.StateNameLabel.AutoSize = true;
            this.StateNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateNameLabel.Location = new System.Drawing.Point(24, 18);
            this.StateNameLabel.Name = "StateNameLabel";
            this.StateNameLabel.Size = new System.Drawing.Size(135, 16);
            this.StateNameLabel.TabIndex = 0;
            this.StateNameLabel.Text = "ИМЯ СОСТОЯНИЯ";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(4, 20);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1239, 42);
            this.HeaderPanel.TabIndex = 1;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.Location = new System.Drawing.Point(23, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(329, 22);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "МАСТЕР СОЗДАНИЯ СОСТОЯНИЙ";
            // 
            // StatePanel
            // 
            this.StatePanel.Controls.Add(this.StateTablePanel);
            this.StatePanel.Controls.Add(this.StateHeaderPanel);
            this.StatePanel.Location = new System.Drawing.Point(31, 164);
            this.StatePanel.Name = "StatePanel";
            this.StatePanel.Size = new System.Drawing.Size(413, 535);
            this.StatePanel.TabIndex = 7;
            // 
            // StateTablePanel
            // 
            this.StateTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateTablePanel.Location = new System.Drawing.Point(0, 51);
            this.StateTablePanel.Name = "StateTablePanel";
            this.StateTablePanel.Size = new System.Drawing.Size(413, 484);
            this.StateTablePanel.TabIndex = 9;
            // 
            // StateHeaderPanel
            // 
            this.StateHeaderPanel.Controls.Add(this.RenewBtn);
            this.StateHeaderPanel.Controls.Add(this.StateHeaderLabel);
            this.StateHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StateHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.StateHeaderPanel.Name = "StateHeaderPanel";
            this.StateHeaderPanel.Size = new System.Drawing.Size(413, 51);
            this.StateHeaderPanel.TabIndex = 8;
            // 
            // StateHeaderLabel
            // 
            this.StateHeaderLabel.AutoSize = true;
            this.StateHeaderLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateHeaderLabel.Location = new System.Drawing.Point(-3, 19);
            this.StateHeaderLabel.Name = "StateHeaderLabel";
            this.StateHeaderLabel.Size = new System.Drawing.Size(74, 16);
            this.StateHeaderLabel.TabIndex = 6;
            this.StateHeaderLabel.Text = "СТАТУСЫ";
            // 
            // ConfirmationPanel
            // 
            this.ConfirmationPanel.Controls.Add(this.SaveLabel);
            this.ConfirmationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConfirmationPanel.Location = new System.Drawing.Point(0, 723);
            this.ConfirmationPanel.Name = "ConfirmationPanel";
            this.ConfirmationPanel.Size = new System.Drawing.Size(1246, 37);
            this.ConfirmationPanel.TabIndex = 8;
            // 
            // SaveLabel
            // 
            this.SaveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveLabel.Location = new System.Drawing.Point(1154, 9);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(76, 19);
            this.SaveLabel.TabIndex = 0;
            this.SaveLabel.Text = "Создать";
            this.SaveLabel.Click += new System.EventHandler(this.SaveLabel_Click);
            // 
            // RenewBtn
            // 
            this.RenewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(75)))), ((int)(((byte)(25)))));
            this.RenewBtn.Font = new System.Drawing.Font("Arial", 10F);
            this.RenewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.RenewBtn.Location = new System.Drawing.Point(310, 12);
            this.RenewBtn.Name = "RenewBtn";
            this.RenewBtn.Size = new System.Drawing.Size(90, 30);
            this.RenewBtn.TabIndex = 7;
            this.RenewBtn.Text = "Обновить";
            this.RenewBtn.UseVisualStyleBackColor = false;
            this.RenewBtn.Click += new System.EventHandler(this.RenewBtn_Click);
            // 
            // StateCreationMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConfirmationPanel);
            this.Controls.Add(this.StatePanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.InfomationPanel);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StateCreationMaster";
            this.Size = new System.Drawing.Size(1246, 760);
            this.Load += new System.EventHandler(this.StateCreationMaster_Load);
            this.InfomationPanel.ResumeLayout(false);
            this.InfomationPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.StatePanel.ResumeLayout(false);
            this.StateHeaderPanel.ResumeLayout(false);
            this.StateHeaderPanel.PerformLayout();
            this.ConfirmationPanel.ResumeLayout(false);
            this.ConfirmationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfomationPanel;
        private System.Windows.Forms.Label StateNameLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private Wrapper.UTextBox StateNameTB;
        private System.Windows.Forms.Panel StatePanel;
        private System.Windows.Forms.Panel StateTablePanel;
        private System.Windows.Forms.Panel StateHeaderPanel;
        private System.Windows.Forms.Label StateHeaderLabel;
        private System.Windows.Forms.Panel ConfirmationPanel;
        private System.Windows.Forms.Label SaveLabel;
        private Wrapper.UButton RenewBtn;
    }
}
