using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap18.Tarea.Modelo
{
    public enum InstructorNivelEnum
    {
        Estable = 1,
        Invitado
    }

    public sealed class Instructor: Colaborador
    {
        public InstructorNivelEnum Nivel { get; set; }

        public override double CalcularBonificacion()
        {
            int valorXAnio = Nivel == InstructorNivelEnum.Estable ? 200 : 120;
            return this.CalcularTiempoServicio() * valorXAnio;
        }
    }
}
