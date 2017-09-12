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
    public partial class Create_Patient_Account : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HABIB\\SQLEXPRESS;Initial Catalog=Medical;User ID=sa;Password=w3123456");
        common.commonClass comm = new MedicalService.common.commonClass();
        public Create_Patient_Account()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (password.Text == confirmpass.Text)
            {
                con.Open();
                SqlCommand adp = new SqlCommand("INSERT INTO [Medical].[dbo].[Patient_Login] ([f_name],[l_name],[user_name],[password]) VALUES('" + fname.Text + "','" + lname.Text + "','" + username.Text + "','" + password.Text + "')", con);
                adp.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Account successfully created.");
            }
            else
            {
                MessageBox.Show("Password does not match.");
 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_profile dp = new Doctors_profile();
            dp.Show();
        }
    }
}