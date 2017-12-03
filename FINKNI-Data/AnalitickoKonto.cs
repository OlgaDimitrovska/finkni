using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINKNI_Data
{
    public class AnalitickoKonto
    {
        private string sifraNaAKonto;
        private string nazivNaAKonto;

        public AnalitickoKonto() { }

        public string SifraNaAKonto
        {
            get
            {
                return sifraNaAKonto;
            }
            set
            {
                sifraNaAKonto = value;
            }
        }

        public string NazivNaAKonto
        {
            get
            {
                return nazivNaAKonto;
            }
            set
            {
                nazivNaAKonto = value;
            }
        }
    }
}
