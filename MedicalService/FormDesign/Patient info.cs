using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicalService.FormDesign
{
    public partial class Patient_info : Form
    {
        public Patient_info()
        {
            InitializeComponent();
        }

        private void Patient_info_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menue mgi = new Menue();
            mgi.Show();
        }
    }
}