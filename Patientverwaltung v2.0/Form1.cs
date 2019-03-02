using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Patientverwaltung_v2._0
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnPatienten.Height;
            SidePanel.Top = btnPatienten.Top;
        }

        private void btnPatienten_Click(object sender, EventArgs e)
        {
            panelTermine.SendToBack();
            panelPatient.BringToFront();


            SidePanel.Height = btnPatienten.Height;
            SidePanel.Top = btnPatienten.Top;

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "db_patientenverwaltung";


            if (dbCon.IsConnect())
            {              

                string query = string.Format("SELECT * FROM patienten");
                var cmd = new MySqlCommand(query, dbCon.Connection);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridViewPatient.DataSource = bSource;
                    sda.Update(dbdataset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                dbCon.Close();
            }

        }

        private void btnTermine_Click(object sender, EventArgs e)
        {
            panelTermine.BringToFront();


            SidePanel.Height = btnTermine.Height;
            SidePanel.Top = btnTermine.Top;

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "db_patientenverwaltung";


            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT * FROM termine");
                var cmd = new MySqlCommand(query, dbCon.Connection);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridViewTermine.DataSource = bSource;
                    sda.Update(dbdataset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                dbCon.Close();
            }

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTermine.Height;
            SidePanel.Top = btnNewPatient.Top;
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelPatient);
            listPanel.Add(panelTermine);
        }
    }
}
