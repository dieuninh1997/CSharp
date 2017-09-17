using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D10cnpm_Bai1_DotNet
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public long UCLN(long a, long b)
        {
            while (b != 0)
            {
                long r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtA.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Số a chưa được nhập!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtA.Focus();
                    return;
                }
                else if (txtB.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Số b chưa được nhập!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtB.Focus();
                    return;
                }
                long a = long.Parse(txtA.Text);
                long b = long.Parse(txtB.Text);
                lbUCLN.Text = lbUCLN.Text + " " + UCLN(a, b);
                lbBCNN.Text = lbBCNN.Text + " " + (a * b) / UCLN(a, b);
                

            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lbBCNN.Text = "BCNN=";
            lbUCLN.Text = "UCLN=";
            txtA.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lbBCNN.Text = "BCNN=";
            lbUCLN.Text = "UCLN=";
            txtA.Focus();
        }
    }
}
