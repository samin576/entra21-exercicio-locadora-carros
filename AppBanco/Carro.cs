namespace AppLocadora
{
    class Carro : Veiculo, IVeiculo
    {
        public Carro(string modelo, string marca, int ano, double valorBase) : base(modelo, marca, ano, valorBase) { }
        public override double CalcularAluguel(int dias)
        {
            return ValorBase * dias;
        }
    }
}
