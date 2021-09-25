using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap17.Ejercicio_1
{
    public class TraianguloEquilatero: Poligono
    {
        public TraianguloEquilatero()
        {
            this.NLados = 3;
        }

        public override double CalcularArea()
        {
            return Lado * Lado * Math.Sqrt(3) / 4;
        }
    }
}
