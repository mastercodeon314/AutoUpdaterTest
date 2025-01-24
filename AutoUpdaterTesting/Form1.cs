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
using AutoUpdaterDotNET;

namespace AutoUpdaterTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the assembly version
            Version assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;

            versionLbl.Text = "Program Version: " + assemblyVersion.ToString();

            AutoUpdater.Start("https://raw.githubusercontent.com/mastercodeon314/AutoUpdaterTest/refs/heads/master/AutoUpdaterTesting/AutoUpdaterTest.xml");
        }
    }
}
