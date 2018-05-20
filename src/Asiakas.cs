namespace VillagePeople
{
    public class Asiakas
    {
        private int asiakas_id;
        private string email;
        private string etunimi;
        private string lahiosoite;
        private string postinro;
        private string postitoimipaikka;
        private string puhelinnro;
        private string sukunimi;

        public Asiakas(int asiakas_id, string etunimi, string sukunimi, string lahiosoite, string postitoimipaikka, string postinro, string email, string puhelinnro)
        {
            this.Asiakas_id = asiakas_id;
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.Lahiosoite = lahiosoite;
            this.Postitoimipaikka = postitoimipaikka;
            this.Postinro = postinro;
            this.Email = email;
            this.Puhelinnro = puhelinnro;
        }

        public int Asiakas_id
        {
            get
            {
                return asiakas_id;
            }

            set
            {
                asiakas_id = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Etunimi
        {
            get
            {
                return etunimi;
            }

            set
            {
                etunimi = value;
            }
        }

        public string Lahiosoite
        {
            get
            {
                return lahiosoite;
            }

            set
            {
                lahiosoite = value;
            }
        }

        public string Postinro
        {
            get
            {
                return postinro;
            }

            set
            {
                postinro = value;
            }
        }

        public string Postitoimipaikka
        {
            get
            {
                return postitoimipaikka;
            }

            set
            {
                postitoimipaikka = value;
            }
        }

        public string Puhelinnro
        {
            get
            {
                return puhelinnro;
            }

            set
            {
                puhelinnro = value;
            }
        }

        public string Sukunimi
        {
            get
            {
                return sukunimi;
            }

            set
            {
                sukunimi = value;
            }
        }

        public string NimiJaEmail
        {
            get
            {
                return string.Format("{0} {1} - {2}", etunimi, sukunimi, email);
            }


        }


        public override string ToString()
        {
            return string.Format("{0} {1} - {2}", etunimi, sukunimi, email);
        }
    }

}