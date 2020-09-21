using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMedidas
{
    public class Decagramos : Valor
    {
        public double calculardecagramos()
        {
            return (this.getNumero() * 100);
        }
    }
}
