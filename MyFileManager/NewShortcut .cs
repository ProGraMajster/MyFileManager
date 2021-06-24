﻿using System;
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
    public static class ShortcutHelper
    {
        
        #region Constants
        /// <summary>
        /// Default shortcut extension
        /// </summary>
        public const string DEFAULT_SHORTCUT_EXTENSION = ".lnk";

        private const string WSCRIPT_SHELL_NAME = "WScript.Shell";
        #endregion

        /// <summary>
        /// Create shortcut in current path.
        /// </summary>
        /// <param name="linkFileName">shortcut name(include .lnk extension.)</param>
        /// <param name="targetPath">target path</param>
        /// <param name="workingDirectory">working path</param>
        /// <param name="arguments">arguments</param>
        /// <param name="hotkey">hot key(ex: Ctrl+Shift+Alt+A)</param>
        /// <param name="shortcutWindowStyle">window style</param>
        /// <param name="description">shortcut description</param>
        /// <param name="iconNumber">icon index(start of 0)</param>
        /// <returns>shortcut file path.</returns>
        /// <exception cref="System.IO.FileNotFoundException"></exception>
        public static string CreateShortcut(
            string linkFileName,
            string targetPath,
            string workingDirectory = "",
            string arguments = "",
            string hotkey = "",
            ShortcutWindowStyles shortcutWindowStyle = ShortcutWindowStyles.WshNormalFocus,
            string description = "",
            int iconNumber = 0)
        {
            if (linkFileName.Contains(DEFAULT_SHORTCUT_EXTENSION) == false)
            {
                linkFileName = string.Format("{0}{1}", linkFileName, DEFAULT_SHORTCUT_EXTENSION);
            }

            if (System.IO.File.Exists(targetPath) == false)
            {
                throw new FileNotFoundException(targetPath);
            }

            if (workingDirectory == string.Empty)
            {
                workingDirectory = Path.GetDirectoryName(targetPath);
            }

            string iconLocation = string.Format("{0},{1}", targetPath, iconNumber);

            if (Environment.Version.Major >= 4)
            {
                Type shellType = Type.GetTypeFromProgID(WSCRIPT_SHELL_NAME);
                dynamic shell = Activator.CreateInstance(shellType);
                dynamic shortcut = shell.CreateShortcut(linkFileName);
                shortcut.TargetPath = targetPath;
                shortcut.WorkingDirectory = workingDirectory;
                shortcut.Arguments = arguments;
                shortcut.Hotkey = hotkey;
                shortcut.WindowStyle = shortcutWindowStyle;
                shortcut.Description = description;
                shortcut.IconLocation = iconLocation;

                shortcut.Save();
            }
            else
            {
                Type shellType = Type.GetTypeFromProgID(WSCRIPT_SHELL_NAME);
                object shell = Activator.CreateInstance(shellType);
                object shortcut = shellType.InvokeMethod("CreateShortcut", shell, linkFileName);
                Type shortcutType = shortcut.GetType();

                shortcutType.InvokeSetMember("TargetPath", shortcut, targetPath);
                shortcutType.InvokeSetMember("WorkingDirectory", shortcut, workingDirectory);
                shortcutType.InvokeSetMember("Arguments", shortcut, arguments);
                shortcutType.InvokeSetMember("Hotkey", shortcut, hotkey);
                shortcutType.InvokeSetMember("WindowStyle", shortcut, shortcutWindowStyle);
                shortcutType.InvokeSetMember("Description", shortcut, description);
                shortcutType.InvokeSetMember("IconLocation", shortcut, iconLocation);

                shortcutType.InvokeMethod("Save", shortcut);
            }

            return Path.Combine(System.Windows.Forms.Application.StartupPath, linkFileName);
        }

        private static object InvokeSetMember(this Type type, string methodName, object targetInstance, params object[] arguments)
        {
            return type.InvokeMember(
                methodName,
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty,
                null,
                targetInstance,
                arguments);
        }

        private static object InvokeMethod(this Type type, string methodName, object targetInstance, params object[] arguments)
        {
            return type.InvokeMember(
                methodName,
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                null,
                targetInstance,
                arguments);
        }

        /// <summary>
        /// windows styles
        /// </summary>
        public enum ShortcutWindowStyles
        {
            /// <summary>
            /// Hide
            /// </summary>
            WshHide = 0,
            /// <summary>
            /// NormalFocus
            /// </summary>
            WshNormalFocus = 1,
            /// <summary>
            /// MinimizedFocus
            /// </summary>
            WshMinimizedFocus = 2,
            /// <summary>
            /// MaximizedFocus
            /// </summary>
            WshMaximizedFocus = 3,
            /// <summary>
            /// NormalNoFocus
            /// </summary>
            WshNormalNoFocus = 4,
            /// <summary>
            /// MinimizedNoFocus
            /// </summary>
            WshMinimizedNoFocus = 6,
        }
    }

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
