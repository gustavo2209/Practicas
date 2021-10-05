using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap19.Domain.Model
{
    public class Alumno
    {

        public Alumno()
        {
            Notas = new List<Nota>();

        }

        public string Nombres { get; set; }

        public List<Nota> Notas { get; set; }
    }
}
