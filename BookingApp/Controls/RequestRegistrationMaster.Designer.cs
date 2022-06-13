namespace BookingApp
{
    partial class RequestRegistrationMaster
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.StatePanel = new System.Windows.Forms.Panel();
            this.StateHeaderPanel = new System.Windows.Forms.Panel();
            this.RoomHeaderLabel = new System.Windows.Forms.Label();
            this.ConfirmationPanel = new System.Windows.Forms.Panel();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PersonHeaderLabel = new System.Windows.Forms.Label();
            this.GuestLabel = new System.Windows.Forms.Label();
            this.AttrLabel = new System.Windows.Forms.Label();
            this.AttrTablePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GuestHeaderLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.EntryDateLabel = new System.Windows.Forms.Label();
            this.EscapeDateLabel = new System.Windows.Forms.Label();
            this.EntryDate = new System.Windows.Forms.DateTimePicker();
            this.EscapeDate = new System.Windows.Forms.DateTimePicker();
            this.RoomTablePanel = new System.Windows.Forms.Panel();
            this.GuestTablePanel = new System.Windows.Forms.Panel();
            this.GuestChooser = new Wrapper.UChooserLink();
            this.HeaderPanel.SuspendLayout();
            this.StatePanel.SuspendLayout();
            this.StateHeaderPanel.SuspendLayout();
            this.ConfirmationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            this.HeaderLabel.Size = new System.Drawing.Size(317, 22);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "МАСТЕР РЕГИСТРАЦИИ ЗАЯВКИ";
            // 
            // StatePanel
            // 
            this.StatePanel.Controls.Add(this.RoomTablePanel);
            this.StatePanel.Controls.Add(this.panel5);
            this.StatePanel.Controls.Add(this.StateHeaderPanel);
            this.StatePanel.Location = new System.Drawing.Point(467, 82);
            this.StatePanel.Name = "StatePanel";
            this.StatePanel.Size = new System.Drawing.Size(413, 248);
            this.StatePanel.TabIndex = 7;
            // 
            // StateHeaderPanel
            // 
            this.StateHeaderPanel.Controls.Add(this.RoomHeaderLabel);
            this.StateHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StateHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.StateHeaderPanel.Name = "StateHeaderPanel";
            this.StateHeaderPanel.Size = new System.Drawing.Size(413, 51);
            this.StateHeaderPanel.TabIndex = 8;
            // 
            // RoomHeaderLabel
            // 
            this.RoomHeaderLabel.AutoSize = true;
            this.RoomHeaderLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomHeaderLabel.Location = new System.Drawing.Point(3, 18);
            this.RoomHeaderLabel.Name = "RoomHeaderLabel";
            this.RoomHeaderLabel.Size = new System.Drawing.Size(81, 16);
            this.RoomHeaderLabel.TabIndex = 6;
            this.RoomHeaderLabel.Text = "КОМНАТЫ";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.AttrTablePanel);
            this.panel1.Controls.Add(this.AttrLabel);
            this.panel1.Controls.Add(this.GuestLabel);
            this.panel1.Controls.Add(this.GuestChooser);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(31, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 489);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PersonHeaderLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 51);
            this.panel2.TabIndex = 9;
            // 
            // PersonHeaderLabel
            // 
            this.PersonHeaderLabel.AutoSize = true;
            this.PersonHeaderLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonHeaderLabel.Location = new System.Drawing.Point(3, 18);
            this.PersonHeaderLabel.Name = "PersonHeaderLabel";
            this.PersonHeaderLabel.Size = new System.Drawing.Size(87, 16);
            this.PersonHeaderLabel.TabIndex = 6;
            this.PersonHeaderLabel.Text = "ЗАЯВКА ОТ";
            // 
            // GuestLabel
            // 
            this.GuestLabel.AutoSize = true;
            this.GuestLabel.Location = new System.Drawing.Point(3, 69);
            this.GuestLabel.Name = "GuestLabel";
            this.GuestLabel.Size = new System.Drawing.Size(49, 16);
            this.GuestLabel.TabIndex = 11;
            this.GuestLabel.Text = "Гость:";
            // 
            // AttrLabel
            // 
            this.AttrLabel.AutoSize = true;
            this.AttrLabel.Location = new System.Drawing.Point(3, 102);
            this.AttrLabel.Name = "AttrLabel";
            this.AttrLabel.Size = new System.Drawing.Size(76, 16);
            this.AttrLabel.TabIndex = 12;
            this.AttrLabel.Text = "Атрибуты:";
            // 
            // AttrTablePanel
            // 
            this.AttrTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AttrTablePanel.Location = new System.Drawing.Point(4, 122);
            this.AttrTablePanel.Name = "AttrTablePanel";
            this.AttrTablePanel.Size = new System.Drawing.Size(406, 364);
            this.AttrTablePanel.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GuestTablePanel);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(467, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 235);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GuestHeaderLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 51);
            this.panel4.TabIndex = 8;
            // 
            // GuestHeaderLabel
            // 
            this.GuestHeaderLabel.AutoSize = true;
            this.GuestHeaderLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestHeaderLabel.Location = new System.Drawing.Point(3, 18);
            this.GuestHeaderLabel.Name = "GuestHeaderLabel";
            this.GuestHeaderLabel.Size = new System.Drawing.Size(55, 16);
            this.GuestHeaderLabel.TabIndex = 6;
            this.GuestHeaderLabel.Text = "ГОСТИ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.EscapeDate);
            this.panel5.Controls.Add(this.EntryDate);
            this.panel5.Controls.Add(this.EscapeDateLabel);
            this.panel5.Controls.Add(this.EntryDateLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(413, 51);
            this.panel5.TabIndex = 9;
            // 
            // EntryDateLabel
            // 
            this.EntryDateLabel.AutoSize = true;
            this.EntryDateLabel.Location = new System.Drawing.Point(6, 4);
            this.EntryDateLabel.Name = "EntryDateLabel";
            this.EntryDateLabel.Size = new System.Drawing.Size(92, 16);
            this.EntryDateLabel.TabIndex = 0;
            this.EntryDateLabel.Text = "Дата заезда:";
            // 
            // EscapeDateLabel
            // 
            this.EscapeDateLabel.AutoSize = true;
            this.EscapeDateLabel.Location = new System.Drawing.Point(205, 4);
            this.EscapeDateLabel.Name = "EscapeDateLabel";
            this.EscapeDateLabel.Size = new System.Drawing.Size(95, 16);
            this.EscapeDateLabel.TabIndex = 1;
            this.EscapeDateLabel.Text = "Дата выезда:";
            // 
            // EntryDate
            // 
            this.EntryDate.Location = new System.Drawing.Point(9, 24);
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.Size = new System.Drawing.Size(157, 23);
            this.EntryDate.TabIndex = 2;
            // 
            // EscapeDate
            // 
            this.EscapeDate.Location = new System.Drawing.Point(208, 24);
            this.EscapeDate.Name = "EscapeDate";
            this.EscapeDate.Size = new System.Drawing.Size(157, 23);
            this.EscapeDate.TabIndex = 3;
            // 
            // RoomTablePanel
            // 
            this.RoomTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomTablePanel.Location = new System.Drawing.Point(0, 51);
            this.RoomTablePanel.Name = "RoomTablePanel";
            this.RoomTablePanel.Size = new System.Drawing.Size(413, 146);
            this.RoomTablePanel.TabIndex = 10;
            // 
            // GuestTablePanel
            // 
            this.GuestTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GuestTablePanel.Location = new System.Drawing.Point(0, 51);
            this.GuestTablePanel.Name = "GuestTablePanel";
            this.GuestTablePanel.Size = new System.Drawing.Size(413, 184);
            this.GuestTablePanel.TabIndex = 9;
            // 
            // GuestChooser
            // 
            this.GuestChooser.AutoSize = true;
            this.GuestChooser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuestChooser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline);
            this.GuestChooser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GuestChooser.Location = new System.Drawing.Point(58, 67);
            this.GuestChooser.Name = "GuestChooser";
            this.GuestChooser.Size = new System.Drawing.Size(114, 18);
            this.GuestChooser.TabIndex = 10;
            this.GuestChooser.Text = "uChooserLink1";
            // 
            // RequestRegistrationMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConfirmationPanel);
            this.Controls.Add(this.StatePanel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequestRegistrationMaster";
            this.Size = new System.Drawing.Size(1246, 760);
            this.Load += new System.EventHandler(this.RequestRegistrationMaster_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.StatePanel.ResumeLayout(false);
            this.StateHeaderPanel.ResumeLayout(false);
            this.StateHeaderPanel.PerformLayout();
            this.ConfirmationPanel.ResumeLayout(false);
            this.ConfirmationPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel StatePanel;
        private System.Windows.Forms.Panel StateHeaderPanel;
        private System.Windows.Forms.Label RoomHeaderLabel;
        private System.Windows.Forms.Panel ConfirmationPanel;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel AttrTablePanel;
        private System.Windows.Forms.Label AttrLabel;
        private System.Windows.Forms.Label GuestLabel;
        private Wrapper.UChooserLink GuestChooser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PersonHeaderLabel;
        private System.Windows.Forms.Panel RoomTablePanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker EscapeDate;
        private System.Windows.Forms.DateTimePicker EntryDate;
        private System.Windows.Forms.Label EscapeDateLabel;
        private System.Windows.Forms.Label EntryDateLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel GuestTablePanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label GuestHeaderLabel;
    }
}
