using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap12
{
    public class Documento
    {
        public int NumeroDocumento { get; set; }

        public DateTime Fecha { get; set; }

        public string Cliente { get; set; }

        public decimal MontoTotal { get; set; }

        public DocumentoItem[] Detalle { get; set; }

        public virtual decimal CalcularTotal()
        {
            decimal suma = 0;

            foreach (DocumentoItem item in Detalle)
            {
                suma += item.SubTotal;
            }
            return suma;
        }
    }
}
