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
    public partial class toimipisteet_UserControl : UserControl
    {
        private VP_database_api db;


        public toimipisteet_UserControl(VP_database_api database)
        {
            db = database;
            InitializeComponent();

        }

        private void toimipisteet_UserControl_Load(object sender, EventArgs e)
        {
            tallenna_button.Enabled = false;
            peruuta_button.Enabled = false;
            toimipisteet_dataGridView.DataSource = db.LataaToimipisteet();
            toimipisteet_dataGridView.Columns[0].Visible = false;
            //toimipisteet_dataGridView.Columns[2].HeaderText = "Toimipaikka";
        }

        private void toimipisteet_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            nimi_textbox.Text = ((Toimipiste)toimipisteet_dataGridView.SelectedRows[0].DataBoundItem).Nimi;
            osoite_textbox.Text = ((Toimipiste)toimipisteet_dataGridView.SelectedRows[0].DataBoundItem).Lahiosoite;
            postitoimipaikka_textbox.Text = ((Toimipiste)toimipisteet_dataGridView.SelectedRows[0].DataBoundItem).Postitoimipaikka;
            postinumero_textbox.Text = ((Toimipiste)toimipisteet_dataGridView.SelectedRows[0].DataBoundItem).Postinro;
            email_textbox.Text = ((Toimipiste)toimipisteet_dataGridView.SelectedRows[0].DataBoundItem).Email;
            puhelinnro_textbox.Text = ((Toimipiste)toimipisteet_dataGridView.SelectedRows[0].DataBoundItem).Puhelinnro;

        }

        private void poista_Toimipiste_button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Haluatko poistaa valitun palvelun", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = ((Toimipiste)toimipisteet_dataGridView.SelectedRows[0].DataBoundItem).Toimipiste_id;
                db.PoistaToimipiste(id);
                toimipisteet_dataGridView.DataSource = db.LataaToimipisteet();
            }
        }

        private void Lisää_Toimipiste_button_Click(object sender, EventArgs e)
        {
            päivitä_button.Enabled = false;
            Lisää_toimipiste_button.Enabled = false;
            poista_toimipiste_button.Enabled = false;
            toimipisteet_dataGridView.Enabled = false;
            tallenna_button.Enabled = true;
            peruuta_button.Enabled = true;
            nimi_textbox.Text = "";
            osoite_textbox.Text = "";
            postitoimipaikka_textbox.Text = "";
            postinumero_textbox.Text = "";
            email_textbox.Text = "";
            puhelinnro_textbox.Text = "";
        }

        private void tallenna_button_Click(object sender, EventArgs e)
        {
            if (nimi_textbox.Text != "" && osoite_textbox.Text != "" && postitoimipaikka_textbox.Text != ""
                && postinumero_textbox.Text != "" && email_textbox.Text != "" && puhelinnro_textbox.Text != "")
            {
                db.LisääToimipiste(nimi_textbox.Text, osoite_textbox.Text, postitoimipaikka_textbox.Text, toimipisteet_dataGridView);
                tallenna_button.Enabled = false;
                peruuta_button.Enabled = false;
                toimipisteet_dataGridView.Enabled = true;
                päivitä_button.Enabled = true;
                Lisää_toimipiste_button.Enabled = true;
                poista_toimipiste_button.Enabled = true;
            }

            else
            {
                MessageBox.Show("täytä kaikki kohdat");
            }

        }

        private void peruuta_button_Click(object sender, EventArgs e)
        {
            tallenna_button.Enabled = false;
            peruuta_button.Enabled = false;
            toimipisteet_dataGridView.Enabled = true;
            päivitä_button.Enabled = true;
            Lisää_toimipiste_button.Enabled = true;
            poista_toimipiste_button.Enabled = true;
        }

        private void päivitä_button_Click(object sender, EventArgs e)
        {
           
        }

        private void postinumero_label_Click(object sender, EventArgs e)
        {

        }

        private void postinumero_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void postitoimipaikka_label_Click(object sender, EventArgs e)
        {

        }

        private void puhelinnro_label_Click(object sender, EventArgs e)
        {

        }
    }
}
