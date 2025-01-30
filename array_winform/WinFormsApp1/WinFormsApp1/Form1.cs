namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void outputArray(double[] Array, ListBox LstBx)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                LstBx.Items.Add(Array[i]);
            }
        }

        public double[] MakeArrayFromTxtBx(TextBox TxtBx)
        {
            int n = TxtBx.Lines.Count();

            double[] arr = new double[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(TxtBx.Lines[i]);
            }

            return arr;
        }

        public double[] CalculateArray(double[] x)
        {

            int count = 0;

            double mid = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 0)
                {
                    mid += x[i];
                    count++;
                }
            }

            mid /= count;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > mid)
                {
                    x[i] = mid;
                }
            }


            return x;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double[] x = CalculateArray(MakeArrayFromTxtBx(inputBox));

            outputArray(x, listBox1);
        }

        private void debugTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
