using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap13
{
    public class Vehiculo
    {
        public int NRuedas { get; set; } = 4;
        public string Placa { get; set; }
        public string Marca { get; set; }
        public int NPuertas { get; set; }
        public double VelocidadMaxima { get; set; } = 100;

        public double CalcularTiempoPromedio(int distancia)
        {
            try
            {
                return distancia / VelocidadMaxima;
            }catch(DivideByZeroException ex)
            {
                throw new Exception("NO ES POSIBLE LA DIVISIÓN ENTRE CERO. LA VELOCIDAD MAXIMA DEBERIA SER MAYOR QUE CERO");
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public string Clasificar()
        {
            if (this.NPuertas == 2)
                return "Pequeño";
            else if (this.NPuertas == 4)
                return "Normal";
            else if (this.NPuertas > 4)
                return "Grande";
            else
                return "NO EXISTE CLASIFICACION";
        }
    }
}
