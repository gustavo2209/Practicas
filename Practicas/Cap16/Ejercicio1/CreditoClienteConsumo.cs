using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap16.Ejercicio1
{
    public class CreditoClienteConsumo : ICredito
    {
        public double MontoSolicitado { get; set; }
        public int NumeroCuotas { get; set; }
        public double CuotaCalculada { get; set; }

        public void Calcular()
        {
            var montoFinal = this.MontoSolicitado + this.MontoSolicitado * 0.5;
            this.CuotaCalculada = montoFinal / NumeroCuotas;
        }
    }
}
