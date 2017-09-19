using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace D10cnpm_Bai1_DotNet
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DIEUNINH\\SQLEXPRESS;Initial Catalog=Bai1DotNet;Integrated Security=True";
            conn.Open();
            /*String query="select count(*) as SL from tb_TaiKhoan where UserName='"+txtUsername.Text+"' and Password='"+txtPass.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int SL = (int)cmd.ExecuteScalar();
            if(SL==1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                D10cnpm_Bai1_DotNet.Properties.Settings.Default.UserName = txtUsername.Text;
                D10cnpm_Bai1_DotNet.Properties.Settings.Default.Save();

                this.Hide();
            }else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }*/

            SqlCommand cmd = new SqlCommand("sp_LogIn", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UserName", txtUsername.Text));
            cmd.Parameters.Add(new SqlParameter("@Password", txtPass.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            if(table.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }



            conn.Close();

        }
    }
}
