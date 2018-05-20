namespace VillagePeople
{
    public class Lasku
    {
        private int lasku_id;
        private Varaus varaus;
        private Asiakas asiakas;
        private double summa;
        private double alv;
        

        public Lasku(int lasku_id, double summa, double alv)
        {
            this.Lasku_id = lasku_id;
            this.Summa = summa;
            this.Alv = alv;
           
           
        }

        public int Lasku_id
        {
            get
            {
                return lasku_id;
            }

            set
            {
                lasku_id = value;
            }
        }

        public double Summa
        {
            get
            {
                return summa;
            }

            set
            {
                summa = value;
            }
        }

        public Asiakas Asiakas
        {
            get
            {
                return asiakas;
            }

            set
            {
                asiakas = value;
            }
        }

        public Varaus Varaus
        {
            get
            {
                return varaus;
            }

            set
            {
                varaus = value;
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
    }

}