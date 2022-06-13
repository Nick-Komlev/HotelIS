namespace Wrapper
{
    partial class BSubprocess
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NameTB.Font = new System.Drawing.Font("Arial", 10F);
            this.NameTB.HideSelection = false;
            this.NameTB.Location = new System.Drawing.Point(0, 26);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTB.Multiline = true;
            this.NameTB.Name = "NameTB";
            this.NameTB.ReadOnly = true;
            this.NameTB.Size = new System.Drawing.Size(98, 72);
            this.NameTB.TabIndex = 0;
            this.NameTB.Text = "1. Название подпроцесса";
            this.NameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BSubprocess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NameTB);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BSubprocess";
            this.Size = new System.Drawing.Size(98, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
    }
}
