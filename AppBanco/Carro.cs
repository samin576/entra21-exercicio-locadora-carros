namespace AppLocadora
{
    public class Carro : Veiculo, IVeiculo
    {
        public Carro(string modelo, string marca, int ano, double precoBase) : base(modelo, marca, ano, precoBase)
        {
        }
        public override double CalcularAluguel(double precoBase)
        {
            Console.WriteLine("Seria por quantos dias?");
            int dias = int.Parse(Console.ReadLine());
            double total = dias * precoBase;
            return total;
        }
    }
}
