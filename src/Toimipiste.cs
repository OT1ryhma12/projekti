namespace VillagePeople
{
    public class Toimipiste
    {
        private int toimipiste_id;
        private string email;
        private string nimi;
        private string lahiosoite;
        private string postinro;
        private string postitoimipaikka;
        private string puhelinnro;

        public Toimipiste(int toimipiste_id, string nimi, string lahiosoite, string postitoimipaikka, string postinro, string email, string puhelinnro)
        {
            this.Toimipiste_id = toimipiste_id;
            this.Nimi = nimi;
            this.Lahiosoite = lahiosoite;
            this.Postitoimipaikka = postitoimipaikka;
            this.Postinro = postinro;
            this.Email = email;
            this.Puhelinnro = puhelinnro;
        }

        public int Toimipiste_id
        {
            get
            {
                return toimipiste_id;
            }

            set
            {
                toimipiste_id = value;
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

        public string Nimi
        {
            get
            {
                return nimi;
            }

            set
            {
                nimi = value;
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

        public override string ToString()
        {
            return this.Nimi;
        }
    }

}