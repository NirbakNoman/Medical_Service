using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicalService.FormDesign
{
    public partial class Menue : Form
    {
        public Menue()
        {
            InitializeComponent();
        }

        private void doctorsEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDesign.child_general_info frm = new child_general_info();
            frm.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDesign.bloodgrp frm = new bloodgrp();
            frm.Show();
        }

        private void Menue_Load(object sender, EventArgs e)
        {

        }

        private void Menue_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_profile ds = new Doctors_profile();
            ds.Show();
        }

        private void commonWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void motherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mother_general_info mgi = new Mother_general_info();
            mgi.Show();
        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_info mgi = new Patient_info();
            mgi.Show();
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prescription mgi = new Prescription();
            mgi.Show();
        }

        private void patientSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_serial_list mgi = new Patient_serial_list();
            mgi.Show();
        }

        private void basicInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            child_general_info mgi = new child_general_info();
            mgi.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Note mgi = new Note();
            mgi.Show();
        }

    }
}