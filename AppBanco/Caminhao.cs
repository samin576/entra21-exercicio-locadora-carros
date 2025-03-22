namespace AppLocadora
{
    class Caminhao : Veiculo, IVeiculo
    {
        public Caminhao(string modelo, string marca, int ano, double valorBase) : base(modelo, marca, ano, valorBase) { }
        public override double CalcularAluguel(int dias)
        {
            double totalDoAluguel = ValorBase * dias;
            totalDoAluguel = totalDoAluguel + (totalDoAluguel * 0.20);
            return totalDoAluguel;
        }
    }
}
