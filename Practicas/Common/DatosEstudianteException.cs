using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Common
{
    class DatosEstudianteException:Exception
    {
        public DatosEstudianteException(int edad): base($"La edad no puede ser mayor que {edad}")
        {

        }
    }
}
