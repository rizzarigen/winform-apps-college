
using System.Runtime.Intrinsics.X86;

namespace logiccalc
{
    public partial class Form1 : Form
    {
        bool[] vala = { false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true };
        bool[] valb = { false, false, false, false, true, true, true, true, false, false, false, false, true, true, true, true };
        bool[] valc = { false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true };
        bool[] vald = { false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true };

        bool op_and(bool a, bool b)
        {
            return a && b;
        }

        bool op_or(bool a, bool b)
        {
            return a || b;
        }

        bool op_eq(bool a, bool b)
        {
            return a == b;
        }
        bool op_neq(bool a, bool b)
        {
            return a != b;
        }

        bool op_n(bool a)
        {
            return !a;
        }

        bool int_to_bool(int num)
        {
            return (num == 1 ? true : false);
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {

        }
        private void label19_Click(object sender, EventArgs e)
        {

        }
        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void listBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                aub.Items.Add(op_or(vala[i], valb[i]) ? '1' : '0');
                anb.Items.Add(op_and(vala[i], valb[i]) ? '1' : '0');
                aeb.Items.Add(op_eq(vala[i], valb[i]) ? '1' : '0');
                aneb.Items.Add(op_neq(vala[i], valb[i]) ? '1' : '0');

                auc.Items.Add(op_or(vala[i], valc[i]) ? '1' : '0');
                anc.Items.Add(op_and(vala[i], valc[i]) ? '1' : '0');
                aec.Items.Add(op_eq(vala[i], valc[i]) ? '1' : '0');
                anec.Items.Add(op_neq(vala[i], valc[i]) ? '1' : '0');

                aud.Items.Add(op_or(vala[i], vald[i]) ? '1' : '0');
                and.Items.Add(op_and(vala[i], vald[i]) ? '1' : '0');
                aed.Items.Add(op_eq(vala[i], vald[i]) ? '1' : '0');
                aned.Items.Add(op_neq(vala[i], vald[i]) ? '1' : '0');

                buc.Items.Add(op_or(valb[i], valc[i]) ? '1' : '0');
                bnc.Items.Add(op_and(valb[i], valc[i]) ? '1' : '0');
                bec.Items.Add(op_eq(valb[i], valc[i]) ? '1' : '0');
                bnec.Items.Add(op_neq(valb[i], valc[i]) ? '1' : '0');

                bud.Items.Add(op_or(valb[i], vald[i]) ? '1' : '0');
                bnd.Items.Add(op_and(valb[i], vald[i]) ? '1' : '0');
                bed.Items.Add(op_eq(valb[i], vald[i]) ? '1' : '0');
                bned.Items.Add(op_neq(valb[i], vald[i]) ? '1' : '0');

                cud.Items.Add(op_or(valc[i], vald[i]) ? '1' : '0');
                cnd.Items.Add(op_and(valc[i], vald[i]) ? '1' : '0');
                ced.Items.Add(op_eq(valc[i], vald[i]) ? '1' : '0');
                cned.Items.Add(op_neq(valc[i], vald[i]) ? '1' : '0');

                na.Items.Add(op_n(vala[i]) ? '1' : '0');
                nb.Items.Add(op_n(valb[i]) ? '1' : '0');
                nc.Items.Add(op_n(valc[i]) ? '1' : '0');
                nd.Items.Add(op_n(vald[i]) ? '1' : '0');


            }

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            aaubb.Items.Clear();
            aanbb.Items.Clear();
            aaebb.Items.Clear();
            aanebb.Items.Clear();

            aaucc.Items.Clear();
            aancc.Items.Clear();
            aaecc.Items.Clear();
            aanecc.Items.Clear();

            aaudd.Items.Clear();
            aandd.Items.Clear();
            aaedd.Items.Clear();
            aanedd.Items.Clear();

            bbucc.Items.Clear();
            bbncc.Items.Clear();
            bbecc.Items.Clear();
            bbnecc.Items.Clear();

            bbudd.Items.Clear();
            bbndd.Items.Clear();
            bbedd.Items.Clear();
            bbnedd.Items.Clear();

            ccudd.Items.Clear();
            ccndd.Items.Clear();
            ccedd.Items.Clear();
            ccnedd.Items.Clear();

            aaubb.Items.Add(op_or(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(bb.Text))) ? "1" : "0");
            aanbb.Items.Add(op_and(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(bb.Text))) ? "1" : "0");
            aaebb.Items.Add(op_eq(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(bb.Text))) ? "1" : "0");
            aanebb.Items.Add(op_neq(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(bb.Text))) ? "1" : "0");

            aaucc.Items.Add(op_or(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(cc.Text))) ? "1" : "0");
            aancc.Items.Add(op_and(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(cc.Text))) ? "1" : "0");
            aaecc.Items.Add(op_eq(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(cc.Text))) ? "1" : "0");
            aanecc.Items.Add(op_neq(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(cc.Text))) ? "1" : "0");

            aaudd.Items.Add(op_or(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");
            aandd.Items.Add(op_and(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");
            aaedd.Items.Add(op_eq(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");
            aanedd.Items.Add(op_neq(int_to_bool(Convert.ToInt32(aa.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");

            bbucc.Items.Add(op_or(int_to_bool(Convert.ToInt32(bb.Text)), int_to_bool(Convert.ToInt32(cc.Text))) ? "1" : "0");
            bbncc.Items.Add(op_and(int_to_bool(Convert.ToInt32(bb.Text)), int_to_bool(Convert.ToInt32(cc.Text))) ? "1" : "0");
            bbecc.Items.Add(op_eq(int_to_bool(Convert.ToInt32(bb.Text)), int_to_bool(Convert.ToInt32(cc.Text))) ? "1" : "0");
            bbnecc.Items.Add(op_neq(int_to_bool(Convert.ToInt32(bb.Text)), int_to_bool(Convert.ToInt32(cc.Text))) ? "1" : "0");

            bbudd.Items.Add(op_or(int_to_bool(Convert.ToInt32(bb.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");
            bbndd.Items.Add(op_and(int_to_bool(Convert.ToInt32(bb.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");
            bbedd.Items.Add(op_eq(int_to_bool(Convert.ToInt32(bb.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");
            bbnedd.Items.Add(op_neq(int_to_bool(Convert.ToInt32(bb.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");

            ccudd.Items.Add(op_or(int_to_bool(Convert.ToInt32(cc.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");
            ccndd.Items.Add(op_and(int_to_bool(Convert.ToInt32(cc.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");
            ccedd.Items.Add(op_eq(int_to_bool(Convert.ToInt32(cc.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");
            ccnedd.Items.Add(op_neq(int_to_bool(Convert.ToInt32(cc.Text)), int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");

            naa.Items.Add(op_n(int_to_bool(Convert.ToInt32(aa.Text))) ? "1" : "0");
            nbb.Items.Add(op_n(int_to_bool(Convert.ToInt32(bb.Text))) ? "1" : "0");
            ncc.Items.Add(op_n(int_to_bool(Convert.ToInt32(cc.Text))) ? "1" : "0");
            ndd.Items.Add(op_n(int_to_bool(Convert.ToInt32(dd.Text))) ? "1" : "0");
        }
    }
}
