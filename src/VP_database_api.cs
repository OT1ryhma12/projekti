using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace VillagePeople
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

       

        public void PoistaAsiakas(int id)
        {
            string Query = "delete from Asiakas where asiakas_id=" + id + " ;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;

          

            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();
                
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

        internal object LataaVarauksenPalvelut(int varaus_id)
        {
            string Query = "select Varauksen_palvelut.varaus_id, Varauksen_palvelut.palvelu_id, Varauksen_palvelut.lkm, Palvelu.palvelu_id, Palvelu.nimi, Palvelu.kuvaus, Palvelu.hinta , Palvelu.alv as Alv" +
                           " from Varauksen_palvelut" +
                           " inner join Palvelu on Varauksen_palvelut.palvelu_id = palvelu.palvelu_id" +
                           " where varaus_id =" + varaus_id;
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;
            List<Palvelu> palvelu = new List<Palvelu>();
            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();


                while (reader.Read())
                {
                    int varauksen_id = reader.GetInt32("varaus_id");
                    int lkm = reader.GetInt32("lkm");
                    int palvelu_id = reader.GetInt32("palvelu_id");
                    string nimi = reader.GetString("nimi");
                    string kuvaus = reader.GetString("kuvaus");
                    double hinta = reader.GetDouble("hinta");
                    double alv = reader.GetDouble("alv");

                    string palvelut = (nimi + " " + kuvaus);
                    Palvelu p = new Palvelu(palvelu_id, nimi, kuvaus, hinta, alv);
                    palvelu.Add(p);
                }

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();
            return palvelu;
        }
    

        public void LisääVarauksenPalvelut(int id, List<Palvelu> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {


                string Query = "insert into Varauksen_palvelut (varaus_id, palvelu_id, lkm) values ('" + id + "', '" + lista[i].Palvelu_id + "', '" + 1 + "')";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
                MySqlDataReader reader;
                try
                {
                    Connection.Open();
                    reader = cmdDataBase.ExecuteReader();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Connection.Close();
            }
        }

        public List<Toimipiste> LataaToimipisteet()
        {
            string Query = "select * from toimipiste";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;
            List<Toimipiste> toimipisteet = new List<Toimipiste>();
            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();


                while (reader.Read())
                {

                    int toimipiste_id = reader.GetInt32("toimipiste_id");
                    string nimi = reader.GetString("nimi");
                    string lahiosoite = reader.GetString("lahiosoite");
                    string postitoimipaikka = reader.GetString("postitoimipaikka");
                    string postinro = reader.GetString("postinro");
                    string email = reader.GetString("email");
                    string puhelinnro = reader.GetString("puhelinnro");

                    Toimipiste a = new Toimipiste(toimipiste_id, nimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro);

                    toimipisteet.Add(a);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();
            return toimipisteet;
        }

   /*     public void LataaToimipiste(DataGridView dataGridView)
        {
            Connection.Open();
            var cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From toimipiste;";
            cmd.ExecuteNonQuery();
            var adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView.Visible = true;
            dataGridView.DataSource = ds.Tables[0].DefaultView;
            Connection.Close();

        }*/

        public void PoistaToimipiste(int id)
        {
            string Query = "delete from toimipiste where toimipiste_id=" + id + " ;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;

            

            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();

        }

        public void LisääToimipiste(string nimi,
           string osoite, string postitoimipaikka, DataGridView dataGridView)
        {

            string Query = "insert into toimipiste (nimi, lahiosoite, postitoimipaikka) values ( '" + nimi + "', '" + osoite + "',  '" + postitoimipaikka + "')";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;
            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();
                MessageBox.Show("toimipiste lisätty");

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

     /*   public void LataaToimipaikat(ComboBox combobox)
        {
            string Query = "select nimi from toimipiste";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;
            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();
                

                while (reader.Read())
                {
                    string toimipiste = reader.GetString("nimi");
                    if (combobox.Items.Contains(toimipiste) == false)
                    {
                        combobox.Items.Add(toimipiste);
                    }
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();
        }*/

      

        public List<Asiakas> LataaAsiakkaat()
        {

            
            string Query = "select * from asiakas";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;
            List<Asiakas> asiakkaat = new List<Asiakas>();
            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();
               

                while (reader.Read())
                {
                   
                    int asiakas_id = reader.GetInt32("asiakas_id");
                    string etunimi = reader.GetString("etunimi");
                    string sukunimi = reader.GetString("sukunimi");
                    string lahiosoite = reader.GetString("lahiosoite");
                    string postitoimipaikka = reader.GetString("postitoimipaikka");
                    string postinro = reader.GetString("postinro");
                    string email = reader.GetString("email");
                    string puhelinnro = reader.GetString("puhelinnro");

                    string asiakas = (etunimi + " " + sukunimi + " - " + email);
                    Asiakas a = new Asiakas(asiakas_id, etunimi, sukunimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro);
                    
                    asiakkaat.Add(a);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();
            return asiakkaat;
        }

        public List<Palvelu> LataaPalvelut()
        {


            string Query = "select Toimipiste.toimipiste_id, Toimipiste.nimi as Toimipiste, Toimipiste.lahiosoite, Toimipiste.postitoimipaikka, Toimipiste.postinro, Toimipiste.email, Toimipiste.puhelinnro, Toimipiste.nimi as Toimipaikka, Palvelu.palvelu_id, Palvelu.nimi as Nimi, Palvelu.kuvaus as Kuvaus, Palvelu.hinta as 'Hinta(Alv 24%)', Palvelu.alv as Alv" +
                              " from Palvelu " +
                              "inner join Toimipiste on Palvelu.toimipiste_id = Toimipiste.toimipiste_id; ";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;
            List<Palvelu> palvelut = new List<Palvelu>();
            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();


                while (reader.Read())
                {

                    int palvelu_id = reader.GetInt32("palvelu_id");
                    string nimi = reader.GetString("nimi");
                    string kuvaus = reader.GetString("kuvaus");
                    double hinta = reader.GetDouble("Hinta(Alv 24%)");
                    double alv = reader.GetDouble("Alv");
                    int toimipiste_id = reader.GetInt32("toimipiste_id");
                    string toimipiste_nimi = reader.GetString("Toimipiste");
                    string toimipiste_osoite = reader.GetString("lahiosoite");
                    string postitoimipaikka = reader.GetString("postitoimipaikka");
                    string postinro = reader.GetString("postinro");
                    string email = reader.GetString("email");
                    string puhelinnro = reader.GetString("puhelinnro");



                    Toimipiste t = new Toimipiste(toimipiste_id, toimipiste_nimi, toimipiste_osoite, postitoimipaikka, postinro, email, puhelinnro);
                    Palvelu p = new Palvelu(palvelu_id, nimi, kuvaus, hinta, alv);
                    p.Toimipiste = t;

                    palvelut.Add(p);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();
            return palvelut;
        }

      /*  public void LataaPalvelut(DataGridView dataGridView)
        {
            Connection.Open();
            var cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Toimipiste.nimi as Toimipaikka, Palvelu.nimi as Nimi, Palvelu.kuvaus as Kuvaus, Palvelu.hinta as 'Hinta(Alv 24%)', Palvelu.alv as Alv" +
                              " from Palvelu "+
                              "inner join Toimipiste on Palvelu.toimipiste_id = Toimipiste.toimipiste_id; ";
            cmd.ExecuteNonQuery();
            var adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView.Visible = true;
            dataGridView.DataSource = ds.Tables[0].DefaultView;
            Connection.Close();

        }*/

        public void LisääPalvelu(int id, string nimi,
         string kuvaus, double hinta, DataGridView dataGridView)
        {
            double alv = hinta * 0.24;
            string Query = "insert into palvelu (toimipiste_id, nimi, kuvaus, hinta, alv) values ('" + id + "', '" + nimi + "', '" + kuvaus + "',  '" + hinta + "', '" + alv + "')";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;
            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();
                MessageBox.Show("palvelu lisätty");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();

        }

        public bool PoistaPalvelu(int id)
        {
            string Query = "delete from palvelu where palvelu_id=" + id + " ;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;

            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            Connection.Close();
            return true;

        }

        public List<Varaus> LataaVaraukset()
        {


            string Query = "select Toimipiste.toimipiste_id, Toimipiste.nimi as Toimipiste, Toimipiste.lahiosoite as toimipisteen_osoite, Toimipiste.postitoimipaikka as toimipisteen_postitoimipaikka, Toimipiste.postinro toimipisteen_postinro, Toimipiste.email as toimipisteen_email, Toimipiste.puhelinnro as toimipisteen_puhelinnro, Toimipiste.nimi as Toimipaikka, Varaus.varaus_id, Varaus.varattu_pvm, Varaus.vahvistus_pvm, Varaus.varattu_alkupvm, Varaus.varattu_loppupvm, Asiakas.asiakas_id, Asiakas.etunimi, Asiakas.sukunimi, Asiakas.lahiosoite, Asiakas.postitoimipaikka, Asiakas.postinro, Asiakas.email, Asiakas.puhelinnro" +
                    " from Varaus" +
                    " inner join Toimipiste on Varaus.toimipiste_id = Toimipiste.toimipiste_id" +
                    " inner join Asiakas on Varaus.asiakas_id = Asiakas.asiakas_id;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;
            List<Varaus> varaukset = new List<Varaus>();
            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();


                while (reader.Read())
                {
                    
                    int varaus_id = reader.GetInt32("varaus_id");
                    DateTime varattu_pvm = reader.GetDateTime("varattu_pvm");
                    DateTime vahvistus_pvm = reader.GetDateTime("vahvistus_pvm");
                    DateTime varattu_alkupvm = reader.GetDateTime("varattu_alkupvm");
                    DateTime varattu_loppupvm = reader.GetDateTime("varattu_loppupvm");
                    int toimipiste_id = reader.GetInt32("toimipiste_id");
                    string toimipiste_nimi = reader.GetString("Toimipiste");
                    string toimipiste_osoite = reader.GetString("toimipisteen_osoite");
                    string postitoimipaikka = reader.GetString("toimipisteen_postitoimipaikka");
                    string postinro = reader.GetString("toimipisteen_postinro");
                    string email = reader.GetString("toimipisteen_email");
                    string puhelinnro = reader.GetString("toimipisteen_puhelinnro");
                   int asiakas_id = reader.GetInt32("asiakas_id");
                    string etunimi = reader.GetString("etunimi");
                    string sukunimi = reader.GetString("sukunimi");
                    string lahiosoite = reader.GetString("lahiosoite");
                    string asiakkaan_postitoimipaikka = reader.GetString("postitoimipaikka");
                    string asiakkaan_postinro = reader.GetString("postinro");
                    string asiakkaan_email = reader.GetString("email");
                    string asiakkaan_puhelinnro = reader.GetString("puhelinnro");




                    Toimipiste t = new Toimipiste(toimipiste_id, toimipiste_nimi, toimipiste_osoite, postitoimipaikka, postinro, email, puhelinnro);
                    Asiakas a = new Asiakas(asiakas_id, etunimi, sukunimi, lahiosoite, asiakkaan_postitoimipaikka, asiakkaan_postinro, asiakkaan_email, asiakkaan_puhelinnro);
                    Varaus v = new Varaus(varaus_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm);
                    v.Toimipiste = t;
                    v.Asiakas = a;
                    

                   varaukset.Add(v);
                    
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();
            return varaukset;
        }

        public int LisääVaraus(int toimipiste_id,int asiakas_id, string varattu_alkupvm, string varattu_loppupvm)
        {
            int id = 0;
            string varattu_pvm = DateTime.Now.ToString("s");
            string vahvistus_pvm = DateTime.Now.ToString("s");
            string Query = "insert into varaus (asiakas_id, toimipiste_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm) values ('" + asiakas_id + "', '" + toimipiste_id + "', '" + varattu_pvm + "', '" + vahvistus_pvm + "', '" + varattu_alkupvm + "', '" + varattu_loppupvm + "')";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            
            MySqlDataReader reader;
            try
            {
                Connection.Open();
                cmdDataBase.ExecuteNonQuery();
                id = (int)cmdDataBase.LastInsertedId;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.Close();
            return id;

        }

        public List<Lasku> LataaLaskut()
        {
            string Query = "select Lasku.lasku_id, Lasku.summa, lasku.alv, Varaus.varaus_id, Varaus.varattu_pvm, Varaus.vahvistus_pvm, Varaus.varattu_alkupvm, Varaus.varattu_loppupvm, Asiakas.asiakas_id, Asiakas.etunimi, Asiakas.sukunimi, Asiakas.lahiosoite, Asiakas.postitoimipaikka, Asiakas.postinro, Asiakas.email, Asiakas.puhelinnro" +
                " from Lasku" +
                " inner join Varaus on Lasku.varaus_id = Varaus.varaus_id" +
                " inner join Asiakas on Lasku.asiakas_id = Asiakas.asiakas_id;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;
            List<Lasku> laskut = new List<Lasku>();
            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();


                while (reader.Read())
                {

                    int lasku_id = reader.GetInt32("lasku_id");
                    double summa = reader.GetDouble("summa");
                    double alv = reader.GetDouble("alv");
                    int varaus_id = reader.GetInt32("varaus_id");
                    DateTime varattu_pvm = reader.GetDateTime("varattu_pvm");
                    DateTime vahvistus_pvm = reader.GetDateTime("vahvistus_pvm");
                    DateTime varattu_alkupvm = reader.GetDateTime("varattu_alkupvm");
                    DateTime varattu_loppupvm = reader.GetDateTime("varattu_loppupvm");
                    int asiakas_id = reader.GetInt32("asiakas_id");
                    string etunimi = reader.GetString("etunimi");
                    string sukunimi = reader.GetString("sukunimi");
                    string lahiosoite = reader.GetString("lahiosoite");
                    string asiakkaan_postitoimipaikka = reader.GetString("Postitoimipaikka");
                    string asiakkaan_postinro = reader.GetString("postinro");
                    string asiakkaan_email = reader.GetString("email");
                    string asiakkaan_puhelinnro = reader.GetString("puhelinnro");




                    Lasku l = new Lasku(lasku_id, summa, alv);
                    Asiakas a = new Asiakas(asiakas_id, etunimi, sukunimi, lahiosoite, asiakkaan_postitoimipaikka, asiakkaan_postinro, asiakkaan_email, asiakkaan_puhelinnro);
                    Varaus v = new Varaus(varaus_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm);
                    l.Asiakas = a;
                    l.Varaus = v;


                    laskut.Add(l);
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();
            return laskut;
        }

      /*  public void LataaLasku(DataGridView dataGridView)
        {
            Connection.Open();
            var cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Lasku;";
            cmd.ExecuteNonQuery();
            var adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView.Visible = true;
            dataGridView.DataSource = ds.Tables[0].DefaultView;
            Connection.Close();

        }*/

        /*public void LisääLasku(string nimi, string osoite, string postitoimipaikka, DataGridView dataGridView)
        {
            string Query = "insert into Lasku (nimi, lahiosoite, postitoimipaikka) values ('" + nimi + "',  '" + osoite + "', '" + postitoimipaikka + "')";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            MySqlDataReader reader;
            try
            {
                Connection.Open();
                reader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Lasku on lisätty");

                while (reader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();

        }*/

        public void LisääLasku(int varaus_id, int asiakas_id, double summa, double alv)
        {

            string s = summa.ToString(CultureInfo.InvariantCulture);
            string a = alv.ToString(CultureInfo.InvariantCulture);

            string Query = String.Format("insert into Lasku (varaus_id, asiakas_id, summa, alv) values ('{0}',  '{1}', '{2}', '{3}')", varaus_id, asiakas_id, s, a);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                cmdDataBase.ExecuteNonQuery();
                //MessageBox.Show("Lasku lisätty");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();

        }

        public void PoistaLasku(DataGridView dataGridView)
        {
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            string Query = "delete from Lasku where lasku_id=" + id + " ;";
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
                MessageBox.Show("Lasku on Poistettu");

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
