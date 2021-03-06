﻿using System;
using System.Windows.Forms;
using log4net.Config;

namespace Log4Net
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            XmlConfigurator.Configure();
        }
    }
}
