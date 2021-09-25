using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap17.Ejercicio_1
{
    public class Cuadrado: Poligono
    {
        public Cuadrado()
        {
            this.NLados = 4;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
