using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillagePeople
{
    public partial class MainForm : Form
    {
        public readonly MySqlConnection Connection;

        private Asiakkaat_UserControl uc1;
        private Palvelut_UserControl uc2;
        private toimipisteet_UserControl uc3;
        private Varaukset_UserControl uc4;
        private Laskut_UserControl uc5;
        private VP_database_api db;

        public MainForm()
        {
            db = new VP_database_api();
            InitializeComponent();
            Connection = new MySqlConnection("host=127.0.0.1;port=3306;user id=root;password=root;database=vp;");
            uc1 = new Asiakkaat_UserControl(db);
            uc2 = new Palvelut_UserControl(db);
            uc3 = new toimipisteet_UserControl(db);
            uc4 = new Varaukset_UserControl(db, näkymät_panel);
            uc5 = new Laskut_UserControl(db);
            uc1.Dock = DockStyle.Fill;
            uc2.Dock = DockStyle.Fill;
            uc3.Dock = DockStyle.Fill;
            uc4.Dock = DockStyle.Fill;
            uc5.Dock = DockStyle.Fill;



            // IsMdiContainer = true;
            //dataGridView1.Visible = false;
        }

        private void toimipisteet_button_click(object sender, EventArgs e)
        {
            näkymät_panel.Controls.Clear();

            näkymät_panel.Controls.Add(uc3);
        }
      
        private void asiakkaat_button_click(object sender, EventArgs e)
        {
            näkymät_panel.Controls.Clear();
           
            näkymät_panel.Controls.Add(uc1);

        }

        private void palvelut_button_click(object sender, EventArgs e)
        {
            näkymät_panel.Controls.Clear();
            
            näkymät_panel.Controls.Add(uc2);
          
        }

        private void varaukset_button_click(object sender, EventArgs e)
        {
            näkymät_panel.Controls.Clear();

            näkymät_panel.Controls.Add(uc4);   
        }

        private void laskut_button_Click(object sender, EventArgs e)
        {
            näkymät_panel.Controls.Clear();

            näkymät_panel.Controls.Add(uc5);
            uc5.PäivitäNäkymä();
        }
    }
}
