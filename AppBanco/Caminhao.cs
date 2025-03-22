using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    class Caminhao : Veiculo, IVeiculo
    {
        public Caminhao() { }
        public override double CalcularAluguel(int dias)
        {
            double totalDoAluguel = ValorBase * dias;            
            totalDoAluguel = totalDoAluguel - (totalDoAluguel * 0.20);
            return totalDoAluguel;
        }
    }
}
