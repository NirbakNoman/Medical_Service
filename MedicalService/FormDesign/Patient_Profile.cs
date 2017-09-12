using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicalService.FormDesign
{
    public partial class Patient_Profile : Form
    {
        public Patient_Profile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Get_Schedule gs = new Get_Schedule();
            gs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_prescription vp = new View_prescription();
            vp.Show();
        }
    }
}