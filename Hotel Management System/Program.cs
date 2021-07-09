using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
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
<<<<<<< HEAD
            Application.Run(new TabMenu());
=======
            Application.Run(new MainLogin());
>>>>>>> 03064b396af63d3bfb1eebf152189e445a338bd4
            //Application.Run(new New());
           
        }
    }
}
