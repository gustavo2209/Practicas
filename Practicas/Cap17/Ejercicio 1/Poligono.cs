using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap17.Ejercicio_1
{
    public class Poligono
    {
        public int NLados { get; set; }

        public double Lado { get; set; }

        public double CalcularPerimetro()
        {
            return NLados * Lado;
        }

        public virtual double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
