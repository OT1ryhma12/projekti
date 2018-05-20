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
    public partial class Palvelut_UserControl : UserControl
    {
        private VP_database_api db;

        public Palvelut_UserControl(VP_database_api database)
        {
            db = database;
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            
        }

        private void Palvelut_UserControl_Load(object sender, EventArgs e)
        {
            palvelut_dataGridView.DataSource = db.LataaPalvelut();

            toimipiste_combobox.Items.AddRange(db.LataaToimipisteet().ToArray());

            palvelut_dataGridView.Columns[0].Visible = false;
            
            //db.LataaToimipaikat(toimipiste_combobox);
            toimipiste_combobox.Enabled = false;
            tallenna_button.Enabled = false;
            peruuta_button.Enabled = false;
        }

        private void palvelut_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nimi_textbox.Text = palvelut_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            kuvaus_textbox.Text = palvelut_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            hinta_textbox.Text = palvelut_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            toimipiste_combobox.Text = ((Palvelu)palvelut_dataGridView.SelectedRows[0].DataBoundItem).Toimipiste.ToString();
        }

        private void Lisää_toimipiste_button_Click(object sender, EventArgs e)
        {
            toimipiste_combobox.Enabled = true;
            nimi_textbox.Text = "";
            kuvaus_textbox.Text = "";
            hinta_textbox.Text = "";
            tallenna_button.Enabled = true;
            peruuta_button.Enabled = true;
            poista_palvelu_button.Enabled = false;
            päivitä_button.Enabled = false;
            palvelut_dataGridView.Enabled = false;
            Lisää_toimipiste_button.Enabled = false;
        }

        private void tallenna_button_Click(object sender, EventArgs e)
        {
            int id = ((Toimipiste)toimipiste_combobox.SelectedItem).Toimipiste_id;
            db.LisääPalvelu(id, nimi_textbox.Text, kuvaus_textbox.Text, double.Parse(hinta_textbox.Text), palvelut_dataGridView);
            palvelut_dataGridView.DataSource = db.LataaPalvelut();
            poista_palvelu_button.Enabled = true;
            päivitä_button.Enabled = true;
            palvelut_dataGridView.Enabled = true;
            tallenna_button.Enabled = false;
            peruuta_button.Enabled = false;
            Lisää_toimipiste_button.Enabled = true;

        }

        private void poista_palvelu_button_Click(object sender, EventArgs e)
        {
             var result = MessageBox.Show("Haluatko poistaa valitun palvelun", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = ((Palvelu)palvelut_dataGridView.SelectedRows[0].DataBoundItem).Palvelu_id;
                db.PoistaPalvelu(id);
                palvelut_dataGridView.DataSource = db.LataaPalvelut();
            }
            
        }

        private void peruuta_button_Click(object sender, EventArgs e)
        {
            poista_palvelu_button.Enabled = true;
            päivitä_button.Enabled = true;
            palvelut_dataGridView.Enabled = true;
            tallenna_button.Enabled = false;
            peruuta_button.Enabled = false;
            Lisää_toimipiste_button.Enabled = true;
        }
    }
}
