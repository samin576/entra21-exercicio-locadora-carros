namespace AppLocadora
{
    class Moto : Veiculo, IVeiculo
    {
        public Moto(string modelo, string marca, int ano, double valorBase) : base(modelo, marca, ano, valorBase) { }
        public override double CalcularAluguel(int dias)
        {
            double totalDoAluguel = ValorBase * dias;
            totalDoAluguel = totalDoAluguel - (totalDoAluguel * 0.10);
            return totalDoAluguel;
        }
    }
}
