using Practicas.Cap19.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas.Cap19.Domain.Model;

namespace Practicas.Cap19.Domain.Services
{
    public class AlumnoServices
    {
        public readonly IAlumnosRepository _alumnoRepository;

        public AlumnoServices(IAlumnosRepository alumnosRepository)
        {
            _alumnoRepository = alumnosRepository;
        }

        public bool AgregarNota(string nombreAlumno, string practica, double nota)
        {
            var esNuevo = false;
            var resultado = false;

            var alumnoEncontrado = _alumnoRepository.Buscar(nombreAlumno);

            if(alumnoEncontrado == null) // SI NO EXISTE EL ALUMNO, SE CREA UNO
            {
                alumnoEncontrado = new Alumno(){Nombres = nombreAlumno };
                esNuevo = true;
            }

            var practicaEncontrada = alumnoEncontrado.Notas.Where(item => item.Practica == practica).FirstOrDefault();

            if(practicaEncontrada == null) // NO EXISTE LA NOTA
            {
                alumnoEncontrado.Notas.Add(new Nota(){ Practica = practica, Calificacion = nota});
            }
            else
            {
                practicaEncontrada.Calificacion = nota;
            }

            if (esNuevo)
            {
                resultado = _alumnoRepository.Agregar(alumnoEncontrado);
            }
            else
            {
                resultado = _alumnoRepository.Modificar(alumnoEncontrado);
            }

            return resultado;
        }
    }
}
