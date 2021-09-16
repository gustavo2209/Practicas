using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap12
{
    public class DocumentoItem
    {
        public int ItemId { get; set; }

        public string Producto { get; set; }

        public decimal Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal SubTotal
        {
            get
            {
                return this.Cantidad * this.Precio;
            }
        }
    }
}
