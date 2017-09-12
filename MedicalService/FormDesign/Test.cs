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
    public partial class Test : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=HABIB\\SQLEXPRESS;Initial Catalog=seveice;User ID=sa;Password=w3123456");
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Test VALUES('" + textBoxName.Text + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                // output the error to see what's going on
                MessageBox.Show(ex.Message);
            }

        }
    }
}