namespace ReceptionApp
{
    partial class MainPage
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
            this.AdminInfPanel = new System.Windows.Forms.Panel();
            this.AdminInfHeaderLabel = new System.Windows.Forms.Label();
            this.LastAuthLabel = new System.Windows.Forms.Label();
            this.LastAuthHeaderLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.FIOHeaderLabel = new System.Windows.Forms.Label();
            this.UserHeaderLabel = new System.Windows.Forms.Label();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.TaskTablePanel = new System.Windows.Forms.Panel();
            this.TaskHeaderLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.AdminInfPanel.SuspendLayout();
            this.TaskPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminInfPanel
            // 
            this.AdminInfPanel.Controls.Add(this.AdminInfHeaderLabel);
            this.AdminInfPanel.Controls.Add(this.LastAuthLabel);
            this.AdminInfPanel.Controls.Add(this.LastAuthHeaderLabel);
            this.AdminInfPanel.Controls.Add(this.FIOLabel);
            this.AdminInfPanel.Controls.Add(this.UserLabel);
            this.AdminInfPanel.Controls.Add(this.FIOHeaderLabel);
            this.AdminInfPanel.Controls.Add(this.UserHeaderLabel);
            this.AdminInfPanel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminInfPanel.Location = new System.Drawing.Point(3, 80);
            this.AdminInfPanel.Name = "AdminInfPanel";
            this.AdminInfPanel.Padding = new System.Windows.Forms.Padding(20);
            this.AdminInfPanel.Size = new System.Drawing.Size(466, 163);
            this.AdminInfPanel.TabIndex = 0;
            // 
            // AdminInfHeaderLabel
            // 
            this.AdminInfHeaderLabel.AutoSize = true;
            this.AdminInfHeaderLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminInfHeaderLabel.Location = new System.Drawing.Point(27, 29);
            this.AdminInfHeaderLabel.Name = "AdminInfHeaderLabel";
            this.AdminInfHeaderLabel.Size = new System.Drawing.Size(274, 18);
            this.AdminInfHeaderLabel.TabIndex = 6;
            this.AdminInfHeaderLabel.Text = "ИНФОРМАЦИЯ О ПОЛЬЗОВАТЕЛЕ";
            // 
            // LastAuthLabel
            // 
            this.LastAuthLabel.AutoSize = true;
            this.LastAuthLabel.Location = new System.Drawing.Point(242, 84);
            this.LastAuthLabel.Name = "LastAuthLabel";
            this.LastAuthLabel.Size = new System.Drawing.Size(120, 16);
            this.LastAuthLabel.TabIndex = 5;
            this.LastAuthLabel.Text = "24.05.2022 17:05";
            // 
            // LastAuthHeaderLabel
            // 
            this.LastAuthHeaderLabel.AutoSize = true;
            this.LastAuthHeaderLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastAuthHeaderLabel.Location = new System.Drawing.Point(239, 64);
            this.LastAuthHeaderLabel.Name = "LastAuthHeaderLabel";
            this.LastAuthHeaderLabel.Size = new System.Drawing.Size(210, 16);
            this.LastAuthHeaderLabel.TabIndex = 4;
            this.LastAuthHeaderLabel.Text = "ПОСЛЕДНЯЯ АВТОРИЗАЦИЯ:";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(30, 137);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(288, 16);
            this.FIOLabel.TabIndex = 3;
            this.FIOLabel.Text = "Сотрудник Службы Приема и размещения";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(27, 84);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(100, 16);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "HOME\\181416";
            // 
            // FIOHeaderLabel
            // 
            this.FIOHeaderLabel.AutoSize = true;
            this.FIOHeaderLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOHeaderLabel.Location = new System.Drawing.Point(24, 117);
            this.FIOHeaderLabel.Name = "FIOHeaderLabel";
            this.FIOHeaderLabel.Size = new System.Drawing.Size(45, 16);
            this.FIOHeaderLabel.TabIndex = 1;
            this.FIOHeaderLabel.Text = "ФИО:";
            // 
            // UserHeaderLabel
            // 
            this.UserHeaderLabel.AutoSize = true;
            this.UserHeaderLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserHeaderLabel.Location = new System.Drawing.Point(24, 64);
            this.UserHeaderLabel.Name = "UserHeaderLabel";
            this.UserHeaderLabel.Size = new System.Drawing.Size(127, 16);
            this.UserHeaderLabel.TabIndex = 0;
            this.UserHeaderLabel.Text = "ПОЛЬЗОВАТЕЛЬ:";
            // 
            // TaskPanel
            // 
            this.TaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskPanel.Controls.Add(this.TaskTablePanel);
            this.TaskPanel.Controls.Add(this.TaskHeaderLabel);
            this.TaskPanel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskPanel.Location = new System.Drawing.Point(3, 253);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(951, 420);
            this.TaskPanel.TabIndex = 7;
            // 
            // TaskTablePanel
            // 
            this.TaskTablePanel.Location = new System.Drawing.Point(33, 51);
            this.TaskTablePanel.Name = "TaskTablePanel";
            this.TaskTablePanel.Size = new System.Drawing.Size(711, 355);
            this.TaskTablePanel.TabIndex = 7;
            // 
            // TaskHeaderLabel
            // 
            this.TaskHeaderLabel.AutoSize = true;
            this.TaskHeaderLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskHeaderLabel.Location = new System.Drawing.Point(27, 29);
            this.TaskHeaderLabel.Name = "TaskHeaderLabel";
            this.TaskHeaderLabel.Size = new System.Drawing.Size(153, 18);
            this.TaskHeaderLabel.TabIndex = 6;
            this.TaskHeaderLabel.Text = "ТЕКУЩИЕ ЗАДАЧИ";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderPanel.Location = new System.Drawing.Point(4, 20);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(944, 53);
            this.HeaderPanel.TabIndex = 8;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.Location = new System.Drawing.Point(23, 9);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(526, 22);
            this.HeaderLabel.TabIndex = 6;
            this.HeaderLabel.Text = "МОДУЛЬ СЛУЖБЫ ПРИЕМА И РАЗМЕЩЕНИЯ | ГЛАВНАЯ";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.TaskPanel);
            this.Controls.Add(this.AdminInfPanel);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(957, 676);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.AdminInfPanel.ResumeLayout(false);
            this.AdminInfPanel.PerformLayout();
            this.TaskPanel.ResumeLayout(false);
            this.TaskPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminInfPanel;
        private System.Windows.Forms.Label AdminInfHeaderLabel;
        private System.Windows.Forms.Label LastAuthLabel;
        private System.Windows.Forms.Label LastAuthHeaderLabel;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label FIOHeaderLabel;
        private System.Windows.Forms.Label UserHeaderLabel;
        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.Label TaskHeaderLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel TaskTablePanel;
    }
}
