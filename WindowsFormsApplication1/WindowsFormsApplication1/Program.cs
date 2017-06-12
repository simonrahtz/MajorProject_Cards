using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

            View v = new View();
            Model m = new Model();
            Controller c = new Controller();

            c.Model = m;
            m.View = v;
            v.Controller = c;
            v.Model = m;

            Application.Run(v);
        }
    }
}
