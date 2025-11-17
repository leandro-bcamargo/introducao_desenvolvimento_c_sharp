using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_EX10_12
{
    internal class Esfera
    {
        // Uma esfera precisa de um raio e de um ponto de origem para ser definida, logo o raio é um atributo essencial.
        private double _raio;

        public double Raio
        {
            get { return _raio; }
            set { _raio = value; }
        }


        public double CalcularVolume()
        {
            return 4 / 3 * Math.PI * Math.Pow(Raio, 3);
        }

    }
}
