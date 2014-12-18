using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Controle_de_consultorio_odonto.Formularios;
using Controle_de_consultorio_odonto.Formularios.Sistema;
using Controle_de_consultorio_odonto.Formularios.Listagens;

namespace Controle_de_consultorio_odonto
{
    static class Program
    {
        static string password;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PasswordScrn());
        }        
        
    }
}
