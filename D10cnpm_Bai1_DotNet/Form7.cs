using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace D10cnpm_Bai1_DotNet
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            String chuoi = txtSearch.Text.ToString();
            MessageBox.Show(convertToUnSign3(chuoi));

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DIEUNINH\\SQLEXPRESS;Initial Catalog=Bai1DotNet;Integrated Security=True";
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_Search", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@chuoi", convertToUnSign3(chuoi)));
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            //duyet qua tat ca cac cot trong reader
            for (int i=0; i<reader.FieldCount; i++)
            {
                table.Columns.Add(i.ToString());
            }
            //duyet qua toan bo cac dong reader
            while(reader.Read())
            {
                object[] arr = new object[reader.FieldCount];
                reader.GetValues(arr);
                table.Rows.Add(arr);
            }
            table.Columns[0].ColumnName = "Tài khoản";
            table.Columns[1].ColumnName = "Mật khẩu";
            dgvSearch.DataSource = table;
            
            conn.Close();
        }
    }
}
