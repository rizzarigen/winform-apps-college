namespace WindowsFormsApp1
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
            this.startValue = new System.Windows.Forms.TextBox();
            this.endValue = new System.Windows.Forms.TextBox();
            this.step = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startValue
            // 
            this.startValue.Location = new System.Drawing.Point(183, 100);
            this.startValue.Name = "startValue";
            this.startValue.Size = new System.Drawing.Size(100, 20);
            this.startValue.TabIndex = 0;
            this.startValue.TextChanged += new System.EventHandler(this.startValue_TextChanged);
            // 
            // endValue
            // 
            this.endValue.Location = new System.Drawing.Point(315, 100);
            this.endValue.Name = "endValue";
            this.endValue.Size = new System.Drawing.Size(100, 20);
            this.endValue.TabIndex = 1;
            this.endValue.TextChanged += new System.EventHandler(this.endValue_TextChanged);
            // 
            // step
            // 
            this.step.Location = new System.Drawing.Point(449, 100);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(100, 20);
            this.step.TabIndex = 2;
            this.step.TextChanged += new System.EventHandler(this.step_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "стартовое значение";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "финальное значение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "шаг";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(340, 283);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Рассчитать";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "x";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(241, 179);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(100, 20);
            this.xBox.TabIndex = 7;
            this.xBox.TextChanged += new System.EventHandler(this.xBox_TextChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(312, 378);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(62, 13);
            this.result.TabIndex = 11;
            this.result.Text = "Результат:";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.step);
            this.Controls.Add(this.endValue);
            this.Controls.Add(this.startValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startValue;
        private System.Windows.Forms.TextBox endValue;
        private System.Windows.Forms.TextBox step;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.Label result;
    }
}

