using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMedidas
{
    public class Miligramos : Valor
    {
        public double calcularMiligramos()
        {
            return (this.getNumero() * 1000000);

        }

    }
}
