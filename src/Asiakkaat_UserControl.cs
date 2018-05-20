using System;
using System.Windows.Forms;

namespace VillagePeople
{
    public partial class Asiakkaat_UserControl : UserControl
    {
       private VP_database_api db;
        

        public Asiakkaat_UserControl(VP_database_api database)
        {
            db = database;
            InitializeComponent();
           
        }

        private void asiakkaat_UserControl_Load(object sender, EventArgs e)
        {
            tallenna_button.Enabled = false;
            peruuta_button.Enabled = false;

            asiakkaat_dataGridView.DataSource = db.LataaAsiakkaat();
            asiakkaat_dataGridView.Columns[0].Visible = false;
        }

        private void asiakkaat_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            etunimi_textbox.Text = ((Asiakas)asiakkaat_dataGridView.SelectedRows[0].DataBoundItem).Etunimi;
            sukunimi_textbox.Text = ((Asiakas)asiakkaat_dataGridView.SelectedRows[0].DataBoundItem).Sukunimi;
            osoite_textbox.Text = ((Asiakas)asiakkaat_dataGridView.SelectedRows[0].DataBoundItem).Lahiosoite;
            postitoimipaikka_textbox.Text = ((Asiakas)asiakkaat_dataGridView.SelectedRows[0].DataBoundItem).Postitoimipaikka;
            postinumero_textbox.Text = ((Asiakas)asiakkaat_dataGridView.SelectedRows[0].DataBoundItem).Postinro;
            email_textbox.Text = ((Asiakas)asiakkaat_dataGridView.SelectedRows[0].DataBoundItem).Email;
            puhelinnro_textbox.Text = ((Asiakas)asiakkaat_dataGridView.SelectedRows[0].DataBoundItem).Puhelinnro;

        }

        private void poista_Asiakas_button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Haluatko poistaa valitun asiakkaan", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = ((Asiakas)asiakkaat_dataGridView.SelectedRows[0].DataBoundItem).Asiakas_id;
                db.PoistaAsiakas(id);
                asiakkaat_dataGridView.DataSource = db.LataaAsiakkaat();
            }
        }

        private void Lisää_asiakas_button_Click(object sender, EventArgs e)
        {
            Lisää_asiakas_button.Enabled = false;
            päivitä_button.Enabled = false;
            poista_asiakas_button.Enabled = false;
            asiakkaat_dataGridView.Enabled = false;
            tallenna_button.Enabled = true;
            peruuta_button.Enabled = true;
            etunimi_textbox.Text = "";
            sukunimi_textbox.Text = "";
            osoite_textbox.Text = "";
            postitoimipaikka_textbox.Text = "";
            postinumero_textbox.Text = "";
            email_textbox.Text = "";
            puhelinnro_textbox.Text = "";

           
        }

        private void päivitä_button_Click(object sender, EventArgs e)
        {
            asiakkaat_dataGridView.DataSource = db.LataaAsiakkaat();
        }

        private void tallenna_button_Click(object sender, EventArgs e)
        {
            if(etunimi_textbox.Text != "" && sukunimi_textbox.Text != "" && osoite_textbox.Text != "" && postitoimipaikka_textbox.Text != "" 
                && postinumero_textbox.Text != "" && email_textbox.Text != "" && puhelinnro_textbox.Text != "")
            {
                db.LisääAsiakas(etunimi_textbox.Text, sukunimi_textbox.Text, osoite_textbox.Text, postitoimipaikka_textbox.Text, asiakkaat_dataGridView);
                tallenna_button.Enabled = false;
                peruuta_button.Enabled = false;
                asiakkaat_dataGridView.Enabled = true;
                päivitä_button.Enabled = true;
                poista_asiakas_button.Enabled = true;
                Lisää_asiakas_button.Enabled = true;
            }

            else
            {
                MessageBox.Show("täytä kaikki kohdat");
            }
           
        }

        private void peruuta_button_Click(object sender, EventArgs e)
        {
            päivitä_button.Enabled = true;
            Lisää_asiakas_button.Enabled = true;
            poista_asiakas_button.Enabled = true;
            tallenna_button.Enabled = false;
            peruuta_button.Enabled = false;
            asiakkaat_dataGridView.Enabled = true;
        }
    }
}
