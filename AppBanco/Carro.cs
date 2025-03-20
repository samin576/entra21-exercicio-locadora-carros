using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    class Carro : Veiculo, IVeiculo
    {
        public Carro() { }


        public override double CalcularAluguel(int dias)
        {
            return base.CalcularAluguel(dias);
        }
    }
}
