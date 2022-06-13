namespace AdminApp
{
    partial class ObjectCreationMaster
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
            this.DescrTB = new Wrapper.UTextBox();
            this.PrefixTB = new Wrapper.UTextBox();
            this.ObjNameTB = new Wrapper.UTextBox();
            this.DescrLabel = new System.Windows.Forms.Label();
            this.PrefixLabel = new System.Windows.Forms.Label();
            this.ObjNameLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.AttrPanel = new System.Windows.Forms.Panel();
            this.AttrTablePanel = new System.Windows.Forms.Panel();
            this.AttrHeaderPanel = new System.Windows.Forms.Panel();
            this.AttrHeaderLabel = new System.Windows.Forms.Label();
            this.StatePanel = new System.Windows.Forms.Panel();
            this.StateTablePanel = new System.Windows.Forms.Panel();
            this.StateHeaderPanel = new System.Windows.Forms.Panel();
            this.StateHeaderLabel = new System.Windows.Forms.Label();
            this.ConfirmationPanel = new System.Windows.Forms.Panel();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.InfomationPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.AttrPanel.SuspendLayout();
            this.AttrHeaderPanel.SuspendLayout();
            this.StatePanel.SuspendLayout();
            this.StateHeaderPanel.SuspendLayout();
            this.ConfirmationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfomationPanel
            // 
            this.InfomationPanel.Controls.Add(this.DescrTB);
            this.InfomationPanel.Controls.Add(this.PrefixTB);
            this.InfomationPanel.Controls.Add(this.ObjNameTB);
            this.InfomationPanel.Controls.Add(this.DescrLabel);
            this.InfomationPanel.Controls.Add(this.PrefixLabel);
            this.InfomationPanel.Controls.Add(this.ObjNameLabel);
            this.InfomationPanel.Location = new System.Drawing.Point(4, 72);
            this.InfomationPanel.Name = "InfomationPanel";
            this.InfomationPanel.Size = new System.Drawing.Size(443, 331);
            this.InfomationPanel.TabIndex = 0;
            // 
            // DescrTB
            // 
            this.DescrTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.DescrTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescrTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.DescrTB.Location = new System.Drawing.Point(27, 178);
            this.DescrTB.Multiline = true;
            this.DescrTB.Name = "DescrTB";
            this.DescrTB.Size = new System.Drawing.Size(413, 150);
            this.DescrTB.TabIndex = 8;
            // 
            // PrefixTB
            // 
            this.PrefixTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.PrefixTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrefixTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.PrefixTB.Location = new System.Drawing.Point(27, 107);
            this.PrefixTB.Name = "PrefixTB";
            this.PrefixTB.Size = new System.Drawing.Size(211, 23);
            this.PrefixTB.TabIndex = 7;
            // 
            // ObjNameTB
            // 
            this.ObjNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.ObjNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.ObjNameTB.Location = new System.Drawing.Point(27, 37);
            this.ObjNameTB.Name = "ObjNameTB";
            this.ObjNameTB.Size = new System.Drawing.Size(211, 23);
            this.ObjNameTB.TabIndex = 6;
            // 
            // DescrLabel
            // 
            this.DescrLabel.AutoSize = true;
            this.DescrLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescrLabel.Location = new System.Drawing.Point(24, 159);
            this.DescrLabel.Name = "DescrLabel";
            this.DescrLabel.Size = new System.Drawing.Size(87, 16);
            this.DescrLabel.TabIndex = 4;
            this.DescrLabel.Text = "ОПИСАНИЕ";
            // 
            // PrefixLabel
            // 
            this.PrefixLabel.AutoSize = true;
            this.PrefixLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrefixLabel.Location = new System.Drawing.Point(24, 88);
            this.PrefixLabel.Name = "PrefixLabel";
            this.PrefixLabel.Size = new System.Drawing.Size(171, 16);
            this.PrefixLabel.TabIndex = 2;
            this.PrefixLabel.Text = "ТАБЛИЧНЫЙ ПРЕФИКС";
            // 
            // ObjNameLabel
            // 
            this.ObjNameLabel.AutoSize = true;
            this.ObjNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObjNameLabel.Location = new System.Drawing.Point(24, 18);
            this.ObjNameLabel.Name = "ObjNameLabel";
            this.ObjNameLabel.Size = new System.Drawing.Size(111, 16);
            this.ObjNameLabel.TabIndex = 0;
            this.ObjNameLabel.Text = "ИМЯ ОБЪЕКТА";
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
            this.HeaderLabel.Size = new System.Drawing.Size(310, 22);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "МАСТЕР СОЗДАНИЯ ОБЪЕКТОВ";
            // 
            // AttrPanel
            // 
            this.AttrPanel.Controls.Add(this.AttrTablePanel);
            this.AttrPanel.Controls.Add(this.AttrHeaderPanel);
            this.AttrPanel.Location = new System.Drawing.Point(483, 72);
            this.AttrPanel.Name = "AttrPanel";
            this.AttrPanel.Size = new System.Drawing.Size(443, 332);
            this.AttrPanel.TabIndex = 6;
            // 
            // AttrTablePanel
            // 
            this.AttrTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttrTablePanel.Location = new System.Drawing.Point(0, 51);
            this.AttrTablePanel.Name = "AttrTablePanel";
            this.AttrTablePanel.Size = new System.Drawing.Size(443, 281);
            this.AttrTablePanel.TabIndex = 8;
            // 
            // AttrHeaderPanel
            // 
            this.AttrHeaderPanel.Controls.Add(this.AttrHeaderLabel);
            this.AttrHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AttrHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.AttrHeaderPanel.Name = "AttrHeaderPanel";
            this.AttrHeaderPanel.Size = new System.Drawing.Size(443, 51);
            this.AttrHeaderPanel.TabIndex = 7;
            // 
            // AttrHeaderLabel
            // 
            this.AttrHeaderLabel.AutoSize = true;
            this.AttrHeaderLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttrHeaderLabel.Location = new System.Drawing.Point(3, 18);
            this.AttrHeaderLabel.Name = "AttrHeaderLabel";
            this.AttrHeaderLabel.Size = new System.Drawing.Size(84, 16);
            this.AttrHeaderLabel.TabIndex = 6;
            this.AttrHeaderLabel.Text = "АТРИБУТЫ";
            // 
            // StatePanel
            // 
            this.StatePanel.Controls.Add(this.StateTablePanel);
            this.StatePanel.Controls.Add(this.StateHeaderPanel);
            this.StatePanel.Location = new System.Drawing.Point(31, 429);
            this.StatePanel.Name = "StatePanel";
            this.StatePanel.Size = new System.Drawing.Size(413, 235);
            this.StatePanel.TabIndex = 7;
            // 
            // StateTablePanel
            // 
            this.StateTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateTablePanel.Location = new System.Drawing.Point(0, 51);
            this.StateTablePanel.Name = "StateTablePanel";
            this.StateTablePanel.Size = new System.Drawing.Size(413, 184);
            this.StateTablePanel.TabIndex = 9;
            // 
            // StateHeaderPanel
            // 
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
            // ObjectCreationMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConfirmationPanel);
            this.Controls.Add(this.StatePanel);
            this.Controls.Add(this.AttrPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.InfomationPanel);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ObjectCreationMaster";
            this.Size = new System.Drawing.Size(1246, 760);
            this.InfomationPanel.ResumeLayout(false);
            this.InfomationPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.AttrPanel.ResumeLayout(false);
            this.AttrHeaderPanel.ResumeLayout(false);
            this.AttrHeaderPanel.PerformLayout();
            this.StatePanel.ResumeLayout(false);
            this.StateHeaderPanel.ResumeLayout(false);
            this.StateHeaderPanel.PerformLayout();
            this.ConfirmationPanel.ResumeLayout(false);
            this.ConfirmationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfomationPanel;
        private System.Windows.Forms.Label DescrLabel;
        private System.Windows.Forms.Label PrefixLabel;
        private System.Windows.Forms.Label ObjNameLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel AttrPanel;
        private System.Windows.Forms.Panel AttrTablePanel;
        private System.Windows.Forms.Panel AttrHeaderPanel;
        private System.Windows.Forms.Label AttrHeaderLabel;
        private Wrapper.UTextBox DescrTB;
        private Wrapper.UTextBox PrefixTB;
        private Wrapper.UTextBox ObjNameTB;
        private System.Windows.Forms.Panel StatePanel;
        private System.Windows.Forms.Panel StateTablePanel;
        private System.Windows.Forms.Panel StateHeaderPanel;
        private System.Windows.Forms.Label StateHeaderLabel;
        private System.Windows.Forms.Panel ConfirmationPanel;
        private System.Windows.Forms.Label SaveLabel;
    }
}
