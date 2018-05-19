using System;
using System.Collections.Generic;

namespace kokeilu
{
    public class Varaus
    {
        private int varaus_id;
        private Asiakas asiakas;
        private Toimipiste toimipiste;
        private DateTime varattu_pmv;
        private DateTime vahvistus_pmv;
        private DateTime varattu_alkupmv;
        private DateTime varattu_loppupmv;
        private List<Palvelu> palvelut;        
        

        public Varaus(int varaus_id, DateTime varattu_pmv, DateTime vahvistus_pmv, DateTime varattu_alkupmv, DateTime varattu_loppupmv)
        {
            this.varaus_id = varaus_id;
            //this.Toimipiste = toimipiste;
            this.varattu_pmv = varattu_pmv;
            this.vahvistus_pmv = vahvistus_pmv;
            this.varattu_alkupmv = varattu_alkupmv;
            this.varattu_loppupmv = varattu_loppupmv;
           
           
        }

        public int Varaus_id
        {
            get
            {
                return varaus_id;
            }

            set
            {
                varaus_id = value;
            }
        }

        public DateTime Varattu_pmv
        {
            get
            {
                return varattu_pmv;
            }

            set
            {
                varattu_pmv = value;
            }
        }

        public DateTime Vahvistus_pmv
        {
            get
            {
                return vahvistus_pmv;
            }

            set
            {
                vahvistus_pmv = value;
            }
        }

        public DateTime Varattu_alkupmv
        {
            get
            {
                return varattu_alkupmv;
            }

            set
            {
                varattu_alkupmv = value;
            }
        }

        public DateTime Varattu_loppupmv
        {
            get
            {
                return varattu_loppupmv;
            }

            set
            {
                varattu_loppupmv = value;
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


    }

}