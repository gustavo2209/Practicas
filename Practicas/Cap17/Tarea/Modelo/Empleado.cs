using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap17.Tarea.Modelo
{
    public enum EmpleadoEstadoEnum
    {
        Directivo = 1,
        Administrativo,
        Asistente
    }

    public class Empleado : Colaborador
    {
        public EmpleadoEstadoEnum Estado { get; set; }

        public override double CalcularBonificacion()
        {
            double bonificacion = 0;

            switch (this.Estado)
            {
                case EmpleadoEstadoEnum.Directivo:
                    bonificacion = 250;
                    break;
                case EmpleadoEstadoEnum.Administrativo:
                    bonificacion = 180;
                    break;
                case EmpleadoEstadoEnum.Asistente:
                    bonificacion = 100;
                    break;
            }
            return this.CalcularTiempoServicio() * bonificacion;
        }
    }
}
