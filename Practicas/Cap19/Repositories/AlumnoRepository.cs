using Practicas.Cap19.AppDbContext;
using Practicas.Cap19.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap19.Repositories
{
    public class AlumnoRepository : IAlumnosRepository
    {
        public readonly NotasDbContext _context;

        public AlumnoRepository(NotasDbContext context)
        {
            _context = context;
        }

        public Alumno Buscar(string nombre)
        {
            // APLICANDO LINQ
            return _context.Alumnos.Where(item => item.Nombres == nombre).FirstOrDefault();
        }

        public bool Grabar(Alumno alumno)
        {
            _context.Alumnos.Add(alumno);
            return true;
        }
    }
}
