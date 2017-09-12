using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedicalService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;

            connetionString = "Server=localhost\\sqlexpress;Database=Medical;User ID=sa;Password=w3123456";
            sql = "INSERT INTO Birth_complexity(p_id,mother,bir_process_code)VALUES('5','rajiya','121')";

            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}