using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Domain
{
    public class Venta
    {
        public int VentaId { get; set; }

        public string Cliente { get; set; }

        public decimal montoTotal { get; set; }
    }
}
