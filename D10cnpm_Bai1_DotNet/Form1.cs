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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            lbKQ.Text = "";
            txtA.Focus();

        }
      


        private void btnGiai_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtA.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Hệ số a chưa được nhập!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtA.Focus();
                    return;
                }
                else if (txtB.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Hệ số b chưa được nhập!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtB.Focus();
                    return;
                }
                else if (txtC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Hệ số c chưa được nhập!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtB.Focus();
                    return;
                }
                double a = Double.Parse(txtA.Text);
                double b = Double.Parse(txtB.Text);
                double c = Double.Parse(txtC.Text);
                double delta = b * b - 4 * a * c;
                if(delta<0)
                {
                    lbKQ.Text = "PT vô nghiệm.";
                }else if(delta==0)
                {
                    lbKQ.Text = "PT có nghiệm kép x1=x2=" + (-b / 2 * a);

                }else
                {
                    lbKQ.Text = "PT có 2 nghiệm phân biệt\nx1= " + (-b - Math.Sqrt(delta)) / 2 * a+"\nx2= "+ (-b + Math.Sqrt(delta)) / 2 * a;
                }
                 

            }
            catch(Exception eX)
            {
                MessageBox.Show(eX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }



        }
    }
}
