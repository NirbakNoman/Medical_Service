using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicalService.FormDesign
{
    public partial class Doctors_profile : Form
    {
        public Doctors_profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDesign.Menue mnu=new Menue();
            mnu.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void newpatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Patient_Account pnlin = new Create_Patient_Account();
            pnlin.Show();

        }

        private void patientlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            OldPatientLogin opln = new OldPatientLogin();
            opln.Show();

        }

        private void doctorlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Login dln = new Doctor_Login();
            dln.Show();
        }
    }
}