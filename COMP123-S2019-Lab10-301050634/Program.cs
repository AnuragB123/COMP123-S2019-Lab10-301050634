using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301050634
{
    static class Program
    {
        //Dictionary that holds the three forms in this application
        public static Dictionary<FormName, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Intializes a new empty Dictionary
            Forms = new Dictionary<FormName, Form>();
            //Adds the three forms in this application
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.MAIN_FORM, new MainForm());
            Forms.Add(FormName.END_FORM, new EndForm());
            //When the application runs, the Start Form runs first
            Application.Run(Forms[FormName.START_FORM]);
        }
    }
}
