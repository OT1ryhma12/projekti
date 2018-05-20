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
    public partial class Uusi_varaus_UserControl : UserControl
    {
        private VP_database_api db;
        private Panel panel;
        private Varaukset_UserControl varaukset_uc;


        public Uusi_varaus_UserControl(VP_database_api database, Panel ucPanel, Varaukset_UserControl uc)
        {
            panel = ucPanel;
            varaukset_uc = uc;
            db = database;
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);

        }

        private void Uusi_varaus_UserControl_Load(object sender, EventArgs e)
        {
            toimipaikat_comboBox.DataSource = db.LataaToimipisteet();
            var asiakkaat = db.LataaAsiakkaat();
            asiakkaat_comboBox.Items.AddRange(asiakkaat.ToArray());
            var palvelut = db.LataaPalvelut();
            palvelut_comboBox.Items.AddRange(palvelut.ToArray());
        }

        private void tee_uusi_varaus_button_Click(object sender, EventArgs e)
        {
            string kokeilu = dateTimePicker1.Value.Date.ToString("s");
            int toimipiste_id = ((Toimipiste)toimipaikat_comboBox.SelectedItem).Toimipiste_id;
            int asiakas_id = ((Asiakas)asiakkaat_comboBox.SelectedItem).Asiakas_id;
            int id = db.LisääVaraus(toimipiste_id, asiakas_id, dateTimePicker1.Value.Date.ToString("s"), dateTimePicker2.Value.Date.ToString("s"));
            int palveluiden_määrä = flowLayoutPanel1.Controls.Count;
            List<Palvelu> lista = new List<Palvelu>();
            for (int i = 0; i < palveluiden_määrä; i++)
            {
                ComboBox cb = ((ComboBox)flowLayoutPanel1.Controls[i]);
                Palvelu p = ((Palvelu)cb.SelectedItem);
                if (p != null)
                {
                    lista.Add(p);
                }

            }
            db.LisääVarauksenPalvelut(id, lista);

            double summa = Math.Round(LaskePalveluidenSumma(lista),2);
            double alv = Math.Round(summa * 0.24, 2);

            db.LisääLasku(id, asiakas_id, summa, alv);

            varaukset_uc.päivitä_näkymä();
            panel.Controls.Clear();
            panel.Controls.Add(varaukset_uc);
           


        }

        private double LaskePalveluidenSumma(List<Palvelu> lista)
        {
            double summa = 0;
            foreach(Palvelu p in lista)
            {
                summa += p.Hinta;
            }

            return summa;
        }

        private void lisää_palvelu_button_click(object sender, EventArgs e)
        {

            if (flowLayoutPanel1.Controls.Count < 5)
            {

                var cb = new ComboBox();
                var palvelut = db.LataaPalvelut();
                cb.DataSource = palvelut;
                cb.DisplayMember = "NimiJaKuvaus";
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                flowLayoutPanel1.Controls.Add(cb);
                cb.Dock = DockStyle.Fill;
                cb.ResetText();
                cb.SelectedIndex = -1;
            }
        }
    }
}
