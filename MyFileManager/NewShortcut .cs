using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.IO;

namespace MyFileManager
{
    public partial class NewShortcut : Form
    {
        string ffilename;
        string ttargrtpath;
        public NewShortcut()
        {
            InitializeComponent();
        }
        public NewShortcut(string filep)
        {
            InitializeComponent();
            try
            {
                ffilename = filep;
                label2.Text = "Lokalizacja pliku żródłowego: " + filep;
                comboBox1.SelectedIndex = 0;
                Icon icon = Icon.ExtractAssociatedIcon(filep);
                pictureBox1.Image = icon.ToBitmap();
            }
            catch
            {

            }
        }

        private void NewShortcut_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length <= 0)
                {
                    MessageBox.Show("Nie podano nazwy skrótu do pliku!");
                    return;
                }
                ShortcutHelper.CreateShortcut(textBox1.Text, ffilename, ttargrtpath,
                    textBox2.Text, textBox3.Text, (ShortcutHelper.ShortcutWindowStyles)comboBox1.SelectedIndex, "", 0);
                MessageBox.Show("Utworzono!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                ttargrtpath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
