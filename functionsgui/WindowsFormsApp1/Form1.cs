using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double x;
        double y;

        double start;
        double end;
        double stepval;
        double sum;

        double Calculate(double x) {
            sum = 0;
            for (x = start; x <= end; x += stepval)
            {
                y = (1 / (x + 2 * Math.PI)) - Math.Sin(x);
                sum += y;
                Console.WriteLine("x=" + x + "; y=" + y);
            }
            return sum;
        }
        public Form1()
        {
            InitializeComponent();
            startValue.TextChanged += startValue_TextChanged;
            endValue.TextChanged += endValue_TextChanged;
            step.TextChanged += step_TextChanged;
            xBox.TextChanged += xBox_TextChanged;
        }

        private void startValue_TextChanged(object sender, EventArgs e)
        {
            start = Convert.ToInt32(startValue.Text);
        }

        private void endValue_TextChanged(object sender, EventArgs e)
        {
            end = Convert.ToInt32(endValue.Text);
        }

        private void step_TextChanged(object sender, EventArgs e)
        {
            stepval = Convert.ToInt32(step.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            result.Text = Convert.ToString(Calculate(x));
        }

        private void yBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void xBox_TextChanged(object sender, EventArgs e)
        {
            x = Convert.ToInt32(xBox.Text);
        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
