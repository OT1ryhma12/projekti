using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace VillagePeople
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
            PäivitäNäkymä();
        }

        public void PäivitäNäkymä()
        {
            laskut_dataGridView.DataSource = db.LataaLaskut();
        }

        private void laskut_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Lasku l = (Lasku)laskut_dataGridView.SelectedRows[0].DataBoundItem;

            txtVarausID.Text = l.Varaus.Varaus_id.ToString();
            txtAsiakasID.Text = l.Asiakas.Asiakas_id.ToString();
            txtNimi.Text = l.Asiakas.ToString();
            txtOsoite.Text = l.Asiakas.Lahiosoite;
            txtPostitoimipaikka.Text = l.Asiakas.Postitoimipaikka;
            txtPostinro.Text = l.Asiakas.Postinro;
            txtSumma.Text = l.Summa.ToString();

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

            //db.LisääLasku(txtNimi.Text, txtOsoite.Text, txtPostitoimipaikka.Text, laskut_dataGridView);

        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            db.PoistaLasku(laskut_dataGridView);
        }

        private void btnPäivitä_Click(object sender, EventArgs e)
        {

        }

    }
}
    