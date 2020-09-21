using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMedidas
{
    public class Gramos : Valor
    {
        public double calcularGramos()
        {
            return (this.getNumero() * 1000);
        }
        
    }
}
