using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFileManager
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            checkBox1.Checked = Properties.Settings.Default.MainDarkBool;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainDarkBool = checkBox1.Checked;
            if(Properties.Settings.Default.MainDarkBool)
            {
                Properties.Settings.Default.DefaultBackColor = Color.FromArgb(24, 24, 24);
                Properties.Settings.Default.DefaultForeColor = Color.FromArgb(250, 250, 250);
            }
            else
            {
                Properties.Settings.Default.DefaultBackColor = Color.White;
                Properties.Settings.Default.DefaultForeColor = Color.Black; 
            }
            Properties.Settings.Default.Save();
            Application.DoEvents();
            this.Hide();
            Application.Restart();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
