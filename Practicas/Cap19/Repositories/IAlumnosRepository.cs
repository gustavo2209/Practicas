using Practicas.Cap19.Domain;
using Practicas.Cap19.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap19.Repositories
{
    public interface IAlumnosRepository
    {
        Alumno Buscar(string nombre);

        bool Grabar(Alumno alumno);
    }
}
