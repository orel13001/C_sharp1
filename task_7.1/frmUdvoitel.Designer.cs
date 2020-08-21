namespace task_7._1
{
    partial class frmUdvoitel
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
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnMultTwo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblComandCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMustGet = new System.Windows.Forms.Label();
            this.btnCancelStep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(158, 33);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(89, 28);
            this.btnAddOne.TabIndex = 0;
            this.btnAddOne.Text = "+1";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnMultTwo
            // 
            this.btnMultTwo.Location = new System.Drawing.Point(158, 74);
            this.btnMultTwo.Name = "btnMultTwo";
            this.btnMultTwo.Size = new System.Drawing.Size(89, 28);
            this.btnMultTwo.TabIndex = 0;
            this.btnMultTwo.Text = "x2";
            this.btnMultTwo.UseVisualStyleBackColor = true;
            this.btnMultTwo.Click += new System.EventHandler(this.btnMultTwo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(158, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Сброс";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(29, 33);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(13, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "0";
            // 
            // lblComandCount
            // 
            this.lblComandCount.AutoSize = true;
            this.lblComandCount.Location = new System.Drawing.Point(29, 74);
            this.lblComandCount.Name = "lblComandCount";
            this.lblComandCount.Size = new System.Drawing.Size(13, 13);
            this.lblComandCount.TabIndex = 1;
            this.lblComandCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Нужно получить:";
            // 
            // lblMustGet
            // 
            this.lblMustGet.AutoSize = true;
            this.lblMustGet.Location = new System.Drawing.Point(109, 167);
            this.lblMustGet.Name = "lblMustGet";
            this.lblMustGet.Size = new System.Drawing.Size(0, 13);
            this.lblMustGet.TabIndex = 2;
            this.lblMustGet.Text = this.val.ToString();
            // 
            // btnCancelStep
            // 
            this.btnCancelStep.Location = new System.Drawing.Point(158, 113);
            this.btnCancelStep.Name = "btnCancelStep";
            this.btnCancelStep.Size = new System.Drawing.Size(89, 28);
            this.btnCancelStep.TabIndex = 0;
            this.btnCancelStep.Text = "Отменить ход";
            this.btnCancelStep.UseVisualStyleBackColor = true;
            this.btnCancelStep.Click += new System.EventHandler(this.btnCancelStep_Click);
            // 
            // frmUdvoitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 217);
            this.Controls.Add(this.lblMustGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblComandCount);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCancelStep);
            this.Controls.Add(this.btnMultTwo);
            this.Controls.Add(this.btnAddOne);
            this.Name = "frmUdvoitel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnMultTwo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblComandCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMustGet;
        private System.Windows.Forms.Button btnCancelStep;
    }
}

