using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap12
{
    class Numero
    {
        public int Valor { get; set; }

        public int CalcularFactorial()
        {
            int fact = 1;

            try
            {
                for(int i=1; i<=Valor; i++)
                {
                    fact = fact * i;
                }
                return fact;
            }catch(Exception ex)
            {
                throw new Exception("vALOR ES MUY GRANDE PARA CALCULAR EL FACTORIAL");
            }
        }

        public bool VerificarSiEsPrimo()
        {
            for(int i=2; i<Valor; i++)
            {
                if (Valor % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
