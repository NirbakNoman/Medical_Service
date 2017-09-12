using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MedicalService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             //Application.Run(new FormDesign.Menue());
            Application.Run(new FormDesign.Doctors_profile());
            //Application.Run(new FormDesign.manu111());
            //Application.Run(new FormDesign.Test());
        }
    }
}