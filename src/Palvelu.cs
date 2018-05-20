namespace VillagePeople
{
    public class Palvelu
    {
        private int palvelu_id;
        private Toimipiste toimipiste;
        private string nimi;
        private string kuvaus;
        private double hinta;
        private double alv;
        

        public Palvelu(int palvelu_id, string nimi, string kuvaus, double hinta, double alv)
        {
            this.Palvelu_id = palvelu_id;
            //this.Toimipiste = toimipiste;
            this.Nimi = nimi;
            this.Kuvaus = kuvaus;
            this.Hinta = hinta;
            this.Alv = alv;
           
           
        }

        public int Palvelu_id
        {
            get
            {
                return palvelu_id;
            }

            set
            {
                palvelu_id = value;
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

        public string Kuvaus
        {
            get
            {
                return kuvaus;
            }

            set
            {
                kuvaus = value;
            }
        }

        public double Hinta
        {
            get
            {
                return hinta;
            }

            set
            {
                hinta = value;
            }
        }

        public double Alv
        {
            get
            {
                return alv;
            }

            set
            {
                alv = value;
            }
        }

        public Toimipiste Toimipiste
        {
            get
            {
                return toimipiste;
            }

            set
            {
                toimipiste = value;
            }
        }


        public string NimiJaKuvaus
        {
            get
            {
                return string.Format("{0} - {1}", nimi, kuvaus);
            }
        }

    }

}