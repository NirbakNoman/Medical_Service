using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicalService.FormDesign
{
    public partial class Get_Schedule : Form
    {
        public Get_Schedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your appointment time is from 8:15PM to 8:30PM. You are requested to attend before this time.");
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_profile dp = new Doctors_profile();
            dp.Show();
        }
    }
}