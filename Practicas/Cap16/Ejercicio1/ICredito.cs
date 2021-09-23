using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap16.Ejercicio1
{
    public interface ICredito
    {
        double MontoSolicitado { get; set; }

        int NumeroCuotas { get; set; }

        double CuotaCalculada { get; set; }

        void Calcular();
    }
}
