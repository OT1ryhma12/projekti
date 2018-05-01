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

namespace kokeilu
{
    public partial class MainForm : Form
    {
        public readonly MySqlConnection Connection;

        private Asiakkaat_UserControl uc1;
        private Palvelut_UserControl uc2;
        private VP_database_api db;

        public MainForm()
        {
            db = new VP_database_api();
            InitializeComponent();
            Connection = new MySqlConnection("host=127.0.0.1;port=3306;user id=root;password=root;database=vp;");
            uc1 = new Asiakkaat_UserControl(db);
            uc2 = new Palvelut_UserControl();
           // IsMdiContainer = true;
            //dataGridView1.Visible = false;
        }

        private void toimipisteet_button_click(object sender, EventArgs e)
        {
           //todo
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
            //todo
        }
    }
}
