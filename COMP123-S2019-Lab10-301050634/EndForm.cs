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
    public partial class EndForm : Form
    {
        /// <summary>
        /// This is the constructor of End Forms
        /// </summary>
        public EndForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler when the Back Button on the form is clicked
        /// It transactions to the Main Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.MAIN_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This is the event handler when the Form is closed when user click the X icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
