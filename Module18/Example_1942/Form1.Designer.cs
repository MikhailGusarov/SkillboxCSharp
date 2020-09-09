namespace Example_1942
{
    partial class mainForm
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
            this.gBox = new System.Windows.Forms.GroupBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.lblResValue = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.btnSum);
            this.gBox.Controls.Add(this.lblResValue);
            this.gBox.Controls.Add(this.lblRes);
            this.gBox.Controls.Add(this.txtBoxB);
            this.gBox.Controls.Add(this.txtBoxA);
            this.gBox.Controls.Add(this.lblB);
            this.gBox.Controls.Add(this.lblA);
            this.gBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBox.Location = new System.Drawing.Point(0, 0);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(588, 203);
            this.gBox.TabIndex = 0;
            this.gBox.TabStop = false;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(378, 41);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(190, 88);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Результат";
            this.btnSum.UseVisualStyleBackColor = true;
            // 
            // lblResValue
            // 
            this.lblResValue.AutoSize = true;
            this.lblResValue.Location = new System.Drawing.Point(104, 157);
            this.lblResValue.Name = "lblResValue";
            this.lblResValue.Size = new System.Drawing.Size(23, 31);
            this.lblResValue.TabIndex = 2;
            this.lblResValue.Text = "-";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(12, 157);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(46, 31);
            this.lblRes.TabIndex = 2;
            this.lblRes.Text = "r =";
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(98, 91);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(224, 38);
            this.txtBoxB.TabIndex = 1;
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(98, 41);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(224, 38);
            this.txtBoxA.TabIndex = 1;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(6, 98);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(52, 31);
            this.lblB.TabIndex = 0;
            this.lblB.Text = "b =";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(6, 44);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(52, 31);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "a =";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 203);
            this.Controls.Add(this.gBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клькулятор v 2.0";
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label lblResValue;
        private System.Windows.Forms.Label lblRes;
    }
}

