﻿using HospitalMS.HelperClasses;
using System;
using System.Windows.Forms;

namespace HospitalMS
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
            Application.Run(new LoginForm());
            //Application.Run(new RegisterForm());
            //Application.Run(new HomeForm());
        }
    }
}
