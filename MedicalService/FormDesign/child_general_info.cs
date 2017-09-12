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
    public partial class child_general_info : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HABIB\\SQLEXPRESS;Initial Catalog=Medical;User ID=sa;Password=w3123456");
        common.commonClass comm = new MedicalService.common.commonClass();
        public child_general_info()
        {
            InitializeComponent();
        }

        private void child_general_info_Load(object sender, EventArgs e)
        {
            gridLoad();
        }
        private void gridLoad()
        {
            //dataGridView1.DataSource = comm.select("select * from child_general_info");

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            comm.nonselect(@"INSERT INTO [dbo].[child_general_info]
           ([p_id]
           ,[name]
           ,[b_date]
           ,[m_name]
           ,[f_name]
           ,[address]
           ,[resident]
           ,[drinking_water]
           ,[washing_water]
           ,[sanitation]
           ,[f_income/month]
           ,[m_income/month]
           ,[t_income/month]
           ,[total_expenses]
           ,[p_blood]
           ,[mt_stool])
     VALUES
           ('1'
           ,'"+textBox1.Text+"','"+dateTimePicker1.Value.ToShortDateString()+"'"+@"
           ,'M'
           ,'F'
           ,'A'
           ,'Re'
           ,'dr'
           ,'Wr'
           ,'SA'
           ,'11.00'
           ,'11.00'
           ,'12.00'
           ,'23.00'
           ,'se'
           ,'pa')");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand adp = new SqlCommand("INSERT INTO [Medical].[dbo].[child_general_info]([name],[b_date],[m_name],[f_name],[address],[drinking_water],[washing_water],[sanitation],[p_blood]) VALUES('" + textBox1.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "'" + @",'" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "','" + comboBox3.SelectedItem.ToString() + "','" + comboBox4.SelectedItem.ToString() + "')", con);
                adp.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Account successfully created.");
            }
            catch (SqlException ex)
            {
                // output the error to see what's going on
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menue mgi = new Menue();
            mgi.Show();
        }
    }
}