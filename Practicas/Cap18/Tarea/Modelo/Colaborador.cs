using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap18.Tarea.Modelo
{
    public abstract class Colaborador : IColaborador
    {
        public string Nombres { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public DateTime FecNacimiento { get; set; }
        public DateTime FecIngreso { get; set; }

        public virtual double CalcularBonificacion()
        {
            throw new NotImplementedException();
        }

        public int CalcularEdad()
        {
            return DateTime.Now.Year - FecNacimiento.Year;
        }

        public int CalcularTiempoServicio()
        {
            return DateTime.Now.Year - FecIngreso.Year;
        }
    }
}
