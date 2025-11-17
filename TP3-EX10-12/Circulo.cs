using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_EX10_12
{
    internal class Circulo
    {
        // Um círculo precisa de um raio e de um ponto de origem para ser definido, logo o raio é um atributo essencial.
        private double _raio;

        public double Raio { get { return _raio; } set { _raio = value; } }
    }
}
