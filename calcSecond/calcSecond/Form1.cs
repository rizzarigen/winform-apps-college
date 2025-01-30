using System;
using System.Collections.Generic;

namespace calcTruhachev
{
    public partial class Form1 : Form
    {
        List<string> data = new List<string>();

        private void ParseCalc(string TextBoxData)
        {
            data = TextBoxData.Split(' ').ToList();
        }

        private int Factorial(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return i * Factorial(i - 1);
            }
        }

        private void calculate(List<string> Array)
        {

            while (Array.Contains('!'.ToString()) == true)
            {
                int i = Array.IndexOf('!'.ToString());

                double v = Factorial(Convert.ToInt32(Array[i - 1]));

                Array[i] = v.ToString();

                Array.RemoveAt(i + 1);
                Array.RemoveAt(i - 1);
            }

            while (Array.Contains('*'.ToString()) == true)
            {
                int i = Array.IndexOf('*'.ToString());

                double v = Convert.ToDouble(Array[i - 1]) * Convert.ToDouble(Array[i + 1]);
                Array[i] = v.ToString();

                Array.RemoveAt(i + 1);
                Array.RemoveAt(i - 1);
            }


            while (Array.Contains('/'.ToString()) == true)
            {
                int i = Array.IndexOf('/'.ToString());

                double v = Convert.ToDouble(Array[i - 1]) / Convert.ToDouble(Array[i + 1]);
                Array[i] = v.ToString();

                Array.RemoveAt(i + 1);
                Array.RemoveAt(i - 1);
            }

            while (Array.Contains('+'.ToString()) == true)
            {
                int i = Array.IndexOf('+'.ToString());

                double v = Convert.ToDouble(Array[i - 1]) + Convert.ToDouble(Array[i + 1]);
                Array[i] = v.ToString();

                Array.RemoveAt(i + 1);
                Array.RemoveAt(i - 1);
            }

            while (Array.Contains('-'.ToString()) == true)
            {
                int i = Array.IndexOf('-'.ToString());

                double v = Convert.ToDouble(Array[i - 1]) - Convert.ToDouble(Array[i + 1]);
                Array[i] = v.ToString();

                Array.RemoveAt(i + 1);
                Array.RemoveAt(i - 1);
            }




        }

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void Display_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
        }

        private void debug_TextChanged(object sender, EventArgs e)
        {
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            textBox1.Text += " * ";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            textBox1.Text += " / ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ! ";
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            ParseCalc(textBox1.Text);

            calculate(data);

            textBox1.Clear();


            for (int i = 0; i <= data.Count - 1; i++)
            {
                textBox1.Text += data[i];
            }




        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void point_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
