using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace kokeilu
{

    public partial class Laskut_UserControl : UserControl
    {
        public MySqlConnection Connection { get; }
        private VP_database_api db;

        public Laskut_UserControl(VP_database_api database)
        {
            Connection = new MySqlConnection("host=127.0.0.1;port=3306;user id=root;password=root;database=vp;");
            db = database;
            InitializeComponent();
        }

        private void Laskut_UserControl_Load(object sender, EventArgs e)
        {
            db.LataaLasku(laskut_dataGridView);
        }

        private void laskut_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtVarausID.Text = laskut_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtAsiakasID.Text = laskut_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtNimi.Text = laskut_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtOsoite.Text = laskut_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtPostitoimipaikka.Text = laskut_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtPostinro.Text = laskut_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
            txtSumma.Text = laskut_dataGridView.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void btnLisää_Click(object sender, EventArgs e)
        {
            String varaus = txtVarausID.ToString();
            int varaus_id = Int32.Parse(varaus);

            String laskuSumma = txtSumma.ToString();
            double summa = Int32.Parse(laskuSumma);

            String asiakas = txtAsiakasID.ToString();
            int asiakas_id = Int32.Parse(asiakas);

           // -- int => char valueen muutto
           String postinumero = txtPostinro.ToString();
           int temp = Int32.Parse(postinumero);
           char postinro = Convert.ToChar(temp);

            String qry = "insert into Lasku (summa, varaus_id, asiakas_id, postinro) values('" + summa + "',  '" + varaus_id + "', " + asiakas_id + "', '" + postinro + "')";

            MySqlCommand add = new MySqlCommand(qry, Connection);

            int i = add.ExecuteNonQuery();

            db.LisääLasku(txtNimi.Text, txtOsoite.Text, txtPostitoimipaikka.Text, laskut_dataGridView);

        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            db.PoistaLasku(laskut_dataGridView);
        }

        private void btnPäivitä_Click(object sender, EventArgs e)
        {
            db.LataaLasku(laskut_dataGridView);
        }

    }
}
