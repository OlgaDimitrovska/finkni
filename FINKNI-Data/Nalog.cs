using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINKNI_Data
{
    public class Nalog
    {
        private string brojNaNalog;
        private DateTime datumNaNalog;
        private decimal saldoDolzi;
        private decimal saldoPobaruva;

        public Nalog() { }

        public string BrojNaNalog
        {
            get
            {
                return brojNaNalog;
            }
            set
            {
                brojNaNalog = value;
            }
        }


        public DateTime DatumNaNaNalog
        {
            get
            {
                return datumNaNalog;
            }
            set
            {
                datumNaNalog = value;
            }
        }

        public decimal SaldoDolzi
        {
            get
            {
                return saldoDolzi;
            }
            set
            {
                saldoDolzi = value;
            }
        }

        public decimal SaldoPobaruva
        {
            get
            {
                return saldoPobaruva;
            }
            set
            {
                saldoPobaruva = value;
            }
        }

    }
}
