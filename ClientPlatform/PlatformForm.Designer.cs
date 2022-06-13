namespace ClientPlatform
{
    partial class PlatformForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конфигурироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.MenuHeaderPanel = new System.Windows.Forms.Panel();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.MenuHeaderLabel = new System.Windows.Forms.Label();
            this.WorkPlacePanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.MenuHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.средстваToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 8, 0, 12);
            this.menuStrip1.Size = new System.Drawing.Size(1184, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // средстваToolStripMenuItem
            // 
            this.средстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конфигурироватьToolStripMenuItem});
            this.средстваToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.средстваToolStripMenuItem.Name = "средстваToolStripMenuItem";
            this.средстваToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.средстваToolStripMenuItem.Text = "Средства";
            // 
            // конфигурироватьToolStripMenuItem
            // 
            this.конфигурироватьToolStripMenuItem.Name = "конфигурироватьToolStripMenuItem";
            this.конфигурироватьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.конфигурироватьToolStripMenuItem.Text = "Конфигурировать";
            this.конфигурироватьToolStripMenuItem.Click += new System.EventHandler(this.КонфигурироватьToolStripMenuItem_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.окноToolStripMenuItem.Text = "Окно";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.LeftPanel.Controls.Add(this.ToolPanel);
            this.LeftPanel.Controls.Add(this.MenuHeaderPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftPanel.Location = new System.Drawing.Point(0, 40);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(338, 572);
            this.LeftPanel.TabIndex = 1;
            // 
            // ToolPanel
            // 
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolPanel.Location = new System.Drawing.Point(0, 40);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(338, 532);
            this.ToolPanel.TabIndex = 1;
            // 
            // MenuHeaderPanel
            // 
            this.MenuHeaderPanel.Controls.Add(this.LinePanel);
            this.MenuHeaderPanel.Controls.Add(this.MenuHeaderLabel);
            this.MenuHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuHeaderPanel.Name = "MenuHeaderPanel";
            this.MenuHeaderPanel.Size = new System.Drawing.Size(338, 40);
            this.MenuHeaderPanel.TabIndex = 0;
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.LinePanel.Location = new System.Drawing.Point(0, 37);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(238, 1);
            this.LinePanel.TabIndex = 1;
            // 
            // MenuHeaderLabel
            // 
            this.MenuHeaderLabel.AutoSize = true;
            this.MenuHeaderLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.MenuHeaderLabel.Location = new System.Drawing.Point(9, 11);
            this.MenuHeaderLabel.Name = "MenuHeaderLabel";
            this.MenuHeaderLabel.Size = new System.Drawing.Size(156, 23);
            this.MenuHeaderLabel.TabIndex = 0;
            this.MenuHeaderLabel.Text = "ПАНЕЛЬ СРЕДСТВ";
            this.MenuHeaderLabel.UseCompatibleTextRendering = true;
            // 
            // WorkPlacePanel
            // 
            this.WorkPlacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.WorkPlacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPlacePanel.Location = new System.Drawing.Point(338, 40);
            this.WorkPlacePanel.Name = "WorkPlacePanel";
            this.WorkPlacePanel.Size = new System.Drawing.Size(846, 572);
            this.WorkPlacePanel.TabIndex = 2;
            // 
            // PlatformForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 612);
            this.Controls.Add(this.WorkPlacePanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlatformForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlatformForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlatformForm_FormClosed);
            this.Load += new System.EventHandler(this.PlatformForm_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PlatformForm_ControlAdded);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.MenuHeaderPanel.ResumeLayout(false);
            this.MenuHeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel MenuHeaderPanel;
        private System.Windows.Forms.Label MenuHeaderLabel;
        private System.Windows.Forms.Panel WorkPlacePanel;
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конфигурироватьToolStripMenuItem;
    }
}

