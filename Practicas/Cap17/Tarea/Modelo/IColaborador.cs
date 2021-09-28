using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap17.Tarea.Modelo
{
    public interface IColaborador
    {
        string Nombres{ get;set; }

        string ApePaterno { get; set; }

        string ApeMaterno { get; set; }

        DateTime FecNacimiento { get; set; }

        DateTime FecIngreso { get; set; }

        int CalcularEdad();

        int CalcularTiempoServicio();

        double CalcularBonificacion();

    }
}
