using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patientverwaltung_v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPatienten_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPatienten.Height;
            SidePanel.Top = btnPatienten.Top;
            patientsControl.BringToFront();
        }

        private void btnTermine_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTermine.Height;
            SidePanel.Top = btnTermine.Top;
            termineControl.BringToFront();
        }
    }
}
