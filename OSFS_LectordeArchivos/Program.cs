﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSFS_LectordeArchivos
{
    static class Program
    {
        /// Comentario GitHub
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// commmit dos
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
