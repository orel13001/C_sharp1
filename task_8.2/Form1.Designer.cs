namespace task_8._2
{
    partial class Form1
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
            this.nudSelect = new System.Windows.Forms.NumericUpDown();
            this.tbResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSelect
            // 
            this.nudSelect.Location = new System.Drawing.Point(28, 50);
            this.nudSelect.Name = "nudSelect";
            this.nudSelect.Size = new System.Drawing.Size(155, 20);
            this.nudSelect.TabIndex = 0;
            this.nudSelect.ValueChanged += new System.EventHandler(this.nudSelect_ValueChanged);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(250, 50);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(159, 20);
            this.tbResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 150);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.nudSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSelect;
        private System.Windows.Forms.TextBox tbResult;
    }
}

