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
    public partial class Mother_general_info : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HABIB\\SQLEXPRESS;Initial Catalog=Medical;User ID=sa;Password=w3123456");
        common.commonClass comm = new MedicalService.common.commonClass();
        public Mother_general_info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menue mgi = new Menue();
            mgi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand adp = new SqlCommand(@"INSERT INTO [Medical].[dbo].[Mother_general_info]([p_id]
           ,[height]
           ,[weight]
           ,[check_up]
           ,[delivery]
           ,[tika])VALUES('','" + textBox2.Text + "','" + mweight.Text + "' ,'" + radioButton1.Checked ? "yes" : "no" + "','" + comboBox1.Text + "','" + comboBox2.Text + "')", con);
            adp.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Info Updated");
        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {
        
        }
    }
}