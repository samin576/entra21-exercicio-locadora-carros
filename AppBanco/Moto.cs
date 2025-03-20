using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    class Moto : Veiculo, IVeiculo
    {
        public Moto() { }
        public override double CalcularAluguel(int dias)
        {
            double totalDoAluguel = ValorBase * dias;
            totalDoAluguel = totalDoAluguel - (totalDoAluguel * 0.10);
            return totalDoAluguel;
        }
    }
}
