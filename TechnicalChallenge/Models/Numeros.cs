using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalChallenge.Models
{

    public class Numeros
    {
        public Numeros(int numero, bool primo)
        {
            Numero = numero;
            Primo = primo;
        }
        public int Numero { get; set; }
        public bool Primo { get; set; }
    }
}
