using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap11
{
    public class Factura
    {
        public string NumeroFactura { get; set; }

        public DateTime FechaEmision { get; set; }

        public string Vendedor { get; set; }

        public string Cliente { get; set; }
    }
}
