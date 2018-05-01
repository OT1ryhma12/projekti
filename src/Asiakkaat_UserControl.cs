using System;
using System.Windows.Forms;

namespace kokeilu
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
            db.LataaAsiakas(asiakkaat_dataGridView);
        }

        private void asiakkaat_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            etunimi_textbox.Text = asiakkaat_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            sukunimi_textbox.Text = asiakkaat_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            osoite_textbox.Text = asiakkaat_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            postitoimipaikka_textbox.Text = asiakkaat_dataGridView.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void poista_Asiakas_button_Click(object sender, EventArgs e)
        {
            db.PoistaAsiakas(asiakkaat_dataGridView);
        }

        private void Lisää_asiakas_button_Click(object sender, EventArgs e)
        {
            db.LisääAsiakas(etunimi_textbox.Text, sukunimi_textbox.Text, osoite_textbox.Text, postitoimipaikka_textbox.Text, asiakkaat_dataGridView);
        }

        private void päivitä_button_Click(object sender, EventArgs e)
        {
            db.LataaAsiakas(asiakkaat_dataGridView);
        }
    }
}
