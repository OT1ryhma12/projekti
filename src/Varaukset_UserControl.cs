using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillagePeople
{
    public partial class Varaukset_UserControl : UserControl
    {
        private VP_database_api db;
        private Panel panel;

        public Varaukset_UserControl(VP_database_api database, Panel ucPanel)
        {
            panel = ucPanel;
            db = database;
            InitializeComponent();
        }

        private void Varaukset_UserControl_Load(object sender, EventArgs e)
        {
            päivitä_näkymä();
        }

        private void uusi_varaus_button_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new Uusi_varaus_UserControl(db, panel, this));
        }

        public void päivitä_näkymä()
        {
            varaukset_dataGridView.DataSource = db.LataaVaraukset();
        }

        private void varaukset_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int varaus_id = ((Varaus)varaukset_dataGridView.SelectedRows[0].DataBoundItem).Varaus_id;
            varaus_id_textbox.Text = varaus_id.ToString();
            varattu_alkupvm_textbox.Text = ((Varaus)varaukset_dataGridView.SelectedRows[0].DataBoundItem).Varattu_alkupmv.ToString();
            varattu_loppupvm_textbox.Text = ((Varaus)varaukset_dataGridView.SelectedRows[0].DataBoundItem).Varattu_loppupmv.ToString();
            toimipiste_combobox.Text = ((Varaus)varaukset_dataGridView.SelectedRows[0].DataBoundItem).Toimipiste.Nimi;
            asiakas_textbox.Text = ((Varaus)varaukset_dataGridView.SelectedRows[0].DataBoundItem).Asiakas.NimiJaEmail;
            palvelut_listbox.DataSource = db.LataaVarauksenPalvelut(varaus_id);
           

        }
    }
}
