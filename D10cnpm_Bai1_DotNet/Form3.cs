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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public bool snt(long n)
        {
           

            if (n < 2)
            {
                return false;

            }
            else if (n == 2)
            {
                return false;
            }
            if (n % 2 == 0)
            { 
                return false;
            }

            long can = (long)Math.Sqrt(n);
            for (int i = 3; i <= can; i += 2)
            {
                if (n % i == 0)
                {
                     return false;
                }
            }
            return true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtN.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Số chưa được nhập!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtN.Focus();
                    return;
                }
                double n = Double.Parse(txtN.Text);
                for (int i = 1; i <= n; i++)
                {
                    if(snt(i)==true)
                    {
                        lbKq.Text = lbKq.Text + " " + i;
                                              
                    }
                }

            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtN.Text = "";
            txtN.Focus();
            lbKq.Text = "";
        }

        private void btnNl_Click(object sender, EventArgs e)
        {
            txtN.Text = "";
            txtN.Focus();
            lbKq.Text = "";
        }
    }
}
