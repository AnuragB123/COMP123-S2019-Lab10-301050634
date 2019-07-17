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
    public partial class MainForm : Form
    {
        /// <summary>
        /// This is the constructor for the MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            EndForm endForm = new EndForm();
            endForm.Show();
            this.Hide();
        }
    }
}
