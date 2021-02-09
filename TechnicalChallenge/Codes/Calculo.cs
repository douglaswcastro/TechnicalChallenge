using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalChallenge.Models;

namespace TechnicalChallenge.Codes
{
    public static class Calculo
    {
        static List<Numeros> numeros = new List<Numeros>();

        public static bool IsNumeroPrimo(int numero)
        {
            int divisores = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores++;
                }

            }

            if (divisores < 3)
                return true;
            else
                return false;
        }
        public static List<Numeros> GetDivisores(int numero)
        {
            for (int i = 1; i <= numero; i++)
            {
                if (((numero % i) == 0))
                {
                    numeros.Add(new Numeros(i, IsNumeroPrimo(i)));
                }
            }
            return numeros;
        }
    }
}
