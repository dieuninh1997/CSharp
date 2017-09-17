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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Số chưa được nhập!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtSo.Focus();
                    return;
                }
               
                long n = long.Parse(txtSo.Text);
                if(n<2)
                {
                    lbKQ.Text="Không là số nguyên tố.";
                    return;
                    
                }else if(n==2)
                {
                    lbKQ.Text = "Không là số nguyên tố.";
                    return;
                }
                if (n % 2 == 0)
                {
                    lbKQ.Text = "Không là số nguyên tố.";
                    return;
                }

                long can = (long)Math.Sqrt(n);
                for(int i=3; i<= can; i+=2)
                {
                    if (n % i == 0)
                    {
                        lbKQ.Text = "Không là số nguyên tố.";
                        return;
                    }
                }

                lbKQ.Text = "Là số nguyên tố.";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtSo.Text = "";
            lbKQ.Text = "";
            txtSo.Focus();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

            txtSo.Text = "";
            lbKQ.Text = "";
            txtSo.Focus();
        }
    }
}
