namespace AppLocadora
{
    public class Caminhao : Veiculo, IVeiculo
    {
        public Caminhao(string modelo, string marca, int ano, double precoBase) : base(modelo, marca, ano, precoBase)
        {
        }
        public override double CalcularAluguel(double precoBase)
        {
            Console.WriteLine("Seria por quantos dias?");
            int dias = int.Parse(Console.ReadLine());
            double totalParcial = dias * precoBase;
            double total = totalParcial + (totalParcial * 0.2);
            return total;

        }
    }
}
