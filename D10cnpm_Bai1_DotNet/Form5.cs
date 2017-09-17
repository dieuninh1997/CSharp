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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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

                int n = int.Parse(txtN.Text);
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        lbH1.Text = lbH1.Text + "*";
                    }
                    lbH1.Text = lbH1.Text + "\n";

                }

                for (int i = 1; i <= n; i++)
                {
                    for (int j = i+1; j<=2*n; j++)
                    {
                        lbH2.Text = lbH2.Text + " ";
                    }
                    for(int j=1; j<=i;j++)
                    {
                        lbH2.Text = lbH2.Text + "*";
                    }
                    lbH2.Text = lbH2.Text + "\n";
                }

                for (int i = n; i >0; i--)
                {
                    for (int j = i; j >0; j--)
                    {
                        lbH3.Text = lbH3.Text + "*";
                    }
                    lbH3.Text = lbH3.Text + "\n";
                }
                for (int i = n; i >=1; i--)
                {
                    for (int j = n-1; j >=i; j--)
                    {
                        lbH4.Text = lbH4.Text + " ";
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        lbH4.Text = lbH4.Text + "*";
                    }
                    lbH4.Text = lbH4.Text + "\n";
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtN.Text = "";
            txtN.Focus();
            lbH1.Text = "";
            lbH2.Text = "";
            lbH3.Text = "";
            lbH4.Text = "";
        }

        private void btnNl_Click(object sender, EventArgs e)
        {

            txtN.Text = "";
            txtN.Focus();
            lbH1.Text = "";
            lbH2.Text = "";
            lbH3.Text = "";
            lbH4.Text = "";
        }
    }
}
