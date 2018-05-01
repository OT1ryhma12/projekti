using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace kokeilu
{
    public class VP_database_api
    {
        public readonly MySqlConnection Connection;

        public VP_database_api()
        {
            Connection = new MySqlConnection("host=127.0.0.1;port=3306;user id=root;password=root;database=vp;");
        }

        public void LataaAsiakas(DataGridView dataGridView)
        {
            Connection.Open();
            var cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Asiakas;";
            cmd.ExecuteNonQuery();
            var adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView.Visible = true;
            dataGridView.DataSource = ds.Tables[0].DefaultView;
            Connection.Close();

        }

       

        public void PoistaAsiakas(DataGridView dataGridView)
        {
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            string Query = "delete from Asiakas where asiakas_id=" + id + " ;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;

            foreach (DataGridViewRow item in dataGridView.SelectedRows)
            {
                dataGridView.Rows.RemoveAt(item.Index);
            }

            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Asiakas Poistettu");
                
                while (reader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();

        }

        public void LisääAsiakas(string etunimi, string sukunimi,
            string osoite, string postitoimipaikka, DataGridView dataGridView)
        { 

            string Query = "insert into Asiakas (etunimi, sukunimi, lahiosoite, postitoimipaikka) values ('" + etunimi + "', '" + sukunimi + "', '" + osoite + "',  '" + postitoimipaikka + "')";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;
            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Asiakas lisätty");

                while (reader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();

        }
    }
}
