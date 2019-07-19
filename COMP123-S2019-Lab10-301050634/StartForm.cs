using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301050634
{
    public partial class StartForm : Form
    {
        /// <summary>
        /// This is the constructor for StartForm
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler when the Start Form loads
        /// The Splash Timer is Enabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        /// <summary>
        /// This is the event handler when the Splash Timer commenses
        /// After 3 Miliseconds it transactions to the Main Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[FormName.MAIN_FORM].Show();
            this.Hide();
        }
    }
}
