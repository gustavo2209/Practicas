using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap13
{
    public class Producto
    {
        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public LineaProducto Linea { get; set; }

        public bool Importado { get; set; }

        /// <summary>
        /// CalcularImporte sin descuento y sin recargo
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public decimal CalcularImporte(int cantidad)
        {
            return CalcularImporte(cantidad, 0, 0);
        }

        /// <summary>
        /// CalcularImporte con descuento
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="porcentajeDescuento"></param>
        /// <returns></returns>
        public decimal CalcularImporte(int cantidad, decimal porcentajeDescuento)
        {
            return CalcularImporte(cantidad, porcentajeDescuento, 0);
        }

        /// <summary>
        /// CalcularImporte con descuento y recargo
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="porcentajeDescuento"></param>
        /// <param name="porcentajeRecargo"></param>
        /// <returns></returns>
        public decimal CalcularImporte(int cantidad, decimal porcentajeDescuento, decimal porcentajeRecargo)
        {
            var total = cantidad * Precio;
            var descuento = total * porcentajeDescuento;
            var recargo = Importado ? total * porcentajeRecargo : 0;

            return total - descuento + recargo;
        }
    }

    public enum LineaProducto
    {
        LineaBlanca,
        Muebles,
        Dormitorio
    }
}
