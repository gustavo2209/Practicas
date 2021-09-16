using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap12
{
    public class Factura: Documento
    {
        private const decimal IGV = 0.18m;

        public override decimal CalcularTotal()
        {
            var total = base.CalcularTotal();
            return total + total * IGV;
        }
    }
}
