namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputBox = new TextBox();
            calculateBtn = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(12, 12);
            inputBox.Multiline = true;
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(112, 192);
            inputBox.TabIndex = 0;
            inputBox.TextChanged += inputBox_TextChanged;
            // 
            // calculateBtn
            // 
            calculateBtn.BackColor = Color.IndianRed;
            calculateBtn.Location = new Point(142, 12);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(381, 192);
            calculateBtn.TabIndex = 1;
            calculateBtn.Text = "button1";
            calculateBtn.UseVisualStyleBackColor = false;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 210);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(108, 124);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 450);
            Controls.Add(listBox1);
            Controls.Add(calculateBtn);
            Controls.Add(inputBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private Button calculateBtn;
        private ListBox listBox1;
    }
}
