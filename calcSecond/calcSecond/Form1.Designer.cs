namespace calcTruhachev
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
            splitContainer1 = new SplitContainer();
            button2 = new Button();
            divide = new Button();
            multi = new Button();
            factorial = new Button();
            minus = new Button();
            plus = new Button();
            point = new Button();
            clear = new Button();
            zero = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            three = new Button();
            two = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 61);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(divide);
            splitContainer1.Panel1.Controls.Add(multi);
            splitContainer1.Panel1.Controls.Add(factorial);
            splitContainer1.Panel1.Controls.Add(minus);
            splitContainer1.Panel1.Controls.Add(plus);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(point);
            splitContainer1.Panel2.Controls.Add(clear);
            splitContainer1.Panel2.Controls.Add(zero);
            splitContainer1.Panel2.Controls.Add(nine);
            splitContainer1.Panel2.Controls.Add(eight);
            splitContainer1.Panel2.Controls.Add(seven);
            splitContainer1.Panel2.Controls.Add(six);
            splitContainer1.Panel2.Controls.Add(five);
            splitContainer1.Panel2.Controls.Add(four);
            splitContainer1.Panel2.Controls.Add(three);
            splitContainer1.Panel2.Controls.Add(two);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(419, 333);
            splitContainer1.SplitterDistance = 139;
            splitContainer1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(29, 212);
            button2.Name = "button2";
            button2.Size = new Size(84, 44);
            button2.TabIndex = 15;
            button2.Text = "!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // divide
            // 
            divide.Location = new Point(29, 164);
            divide.Name = "divide";
            divide.Size = new Size(84, 44);
            divide.TabIndex = 14;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // multi
            // 
            multi.Location = new Point(29, 114);
            multi.Name = "multi";
            multi.Size = new Size(84, 44);
            multi.TabIndex = 13;
            multi.Text = "*";
            multi.UseVisualStyleBackColor = true;
            multi.Click += multi_Click;
            // 
            // factorial
            // 
            factorial.Location = new Point(29, 262);
            factorial.Name = "factorial";
            factorial.Size = new Size(84, 44);
            factorial.TabIndex = 12;
            factorial.Text = "=";
            factorial.UseVisualStyleBackColor = true;
            factorial.Click += factorial_Click;
            // 
            // minus
            // 
            minus.Location = new Point(29, 64);
            minus.Name = "minus";
            minus.Size = new Size(84, 44);
            minus.TabIndex = 11;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // plus
            // 
            plus.Location = new Point(29, 14);
            plus.Name = "plus";
            plus.Size = new Size(84, 44);
            plus.TabIndex = 10;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // point
            // 
            point.Location = new Point(3, 212);
            point.Name = "point";
            point.Size = new Size(84, 60);
            point.TabIndex = 12;
            point.Text = ",";
            point.UseVisualStyleBackColor = true;
            point.Click += point_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.IndianRed;
            clear.Location = new Point(183, 212);
            clear.Name = "clear";
            clear.Size = new Size(81, 60);
            clear.TabIndex = 11;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // zero
            // 
            zero.Location = new Point(93, 212);
            zero.Name = "zero";
            zero.Size = new Size(84, 60);
            zero.TabIndex = 9;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // nine
            // 
            nine.Location = new Point(183, 146);
            nine.Name = "nine";
            nine.Size = new Size(81, 60);
            nine.TabIndex = 8;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // eight
            // 
            eight.Location = new Point(93, 146);
            eight.Name = "eight";
            eight.Size = new Size(84, 60);
            eight.TabIndex = 7;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // seven
            // 
            seven.Location = new Point(3, 146);
            seven.Name = "seven";
            seven.Size = new Size(84, 60);
            seven.TabIndex = 6;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // six
            // 
            six.Location = new Point(183, 80);
            six.Name = "six";
            six.Size = new Size(81, 60);
            six.TabIndex = 5;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // five
            // 
            five.Location = new Point(93, 80);
            five.Name = "five";
            five.Size = new Size(84, 60);
            five.TabIndex = 4;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // four
            // 
            four.Location = new Point(3, 80);
            four.Name = "four";
            four.Size = new Size(84, 60);
            four.TabIndex = 3;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // three
            // 
            three.Location = new Point(183, 14);
            three.Name = "three";
            three.Size = new Size(81, 60);
            three.TabIndex = 2;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // two
            // 
            two.Location = new Point(93, 14);
            two.Name = "two";
            two.Size = new Size(84, 60);
            two.TabIndex = 1;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 14);
            button1.Name = "button1";
            button1.Size = new Size(84, 60);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.ForestGreen;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Miriam Mono CLM", 25F);
            textBox1.ForeColor = Color.LightGreen;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(425, 41);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(449, 403);
            Controls.Add(textBox1);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitContainer1;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button six;
        private Button five;
        private Button four;
        private Button three;
        private Button two;
        private Button button1;
        private Button multi;
        private Button factorial;
        private Button minus;
        private Button plus;
        private Button zero;
        private Button button2;
        private Button divide;
        private TextBox textBox1;
        private Button clear;
        private Button point;
    }
}
