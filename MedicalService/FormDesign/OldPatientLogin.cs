using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedicalService.FormDesign
{
    public partial class OldPatientLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HABIB\\SQLEXPRESS;Initial Catalog=Medical;User ID=sa;Password=w3123456");
        public OldPatientLogin()
        {
            InitializeComponent();
        }

        private void creatAcnt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Patient_Account pnln = new Create_Patient_Account();
            pnln.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp=new SqlDataAdapter("SELECT [id],[f_name],[l_name],[user_name],[password] FROM [Medical].[dbo].[Patient_Login] where user_name='"+textBox1.Text+"' and password='"+textBox2.Text+"' ",con);
            DataTable dt=new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Patient_Profile ps = new Patient_Profile();
                ps.Show();
            }
            else
            {
                MessageBox.Show("Invelid Username or Password");
            }
        }
    }
}