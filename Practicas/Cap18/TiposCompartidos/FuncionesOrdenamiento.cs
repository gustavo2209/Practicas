using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap18.TiposCompartidos
{
    public class FuncionesOrdenamiento
    {
        public static int[] Ascendente(int [] arreglo)
        {
            for(int j=0; j < arreglo.Length; j++)
            {
                for(int i =0; i<arreglo.Length - 1; i++)
                {
                    if(arreglo[i] > arreglo[i + 1])
                    {
                        int mayor = arreglo[i];
                        arreglo[i] = arreglo[i + 1];
                        arreglo[i + 1] = mayor;
                    }
                }
            }
            return arreglo;
        }
    }
}
