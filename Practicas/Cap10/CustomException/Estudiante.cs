using Practicas.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap10.CustomException
{
    class Estudiante
    {

        public Estudiante(string nombre, DateTime fechaNacimiento)
        {
            var edad = DateTime.Now.Year - fechaNacimiento.Year;

            if(edad > 16)
            {
                throw new DatosEstudianteException(15);
            }
        }

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
