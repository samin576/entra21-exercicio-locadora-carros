namespace AppLocadora
{
    class Veiculo : IVeiculo
    {
        List<Veiculo> VeiculosCadastrados = new List<Veiculo>();
        private string _modelo;
        private string _marca;
        private int _ano;
        private double _valorBase;

        public Veiculo(string modelo, string marca, int ano, double valorBase)
        {
            _modelo = modelo;
            _marca = marca;
            _ano = ano;
            _valorBase = valorBase;
        }
        public Veiculo() { }

        public string Modelo
        { get { return _modelo; } set { _modelo = value; } }
        public string Marca
        { get { return _marca; } set { _marca = value; } }
        public int Ano
        { get { return _ano; } set { _ano = value; } }
        public double ValorBase
        { get { return _valorBase; } set { _valorBase = value; } }
        public void CadastrarVeiculo()
        {
            Veiculo novoVeiculo = new Veiculo();
            Console.WriteLine("Qual é o modelo do veiculo?");
            novoVeiculo.Modelo = Console.ReadLine();
            Console.WriteLine("Qual é a marca?");
            novoVeiculo.Marca = Console.ReadLine();
            Console.WriteLine("Qual é o ano?");
            novoVeiculo.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o valor base dele?");
            novoVeiculo.ValorBase = double.Parse(Console.ReadLine());
            VeiculosCadastrados.Add(novoVeiculo);
            Console.WriteLine("Veículo cadastrado com sucesso!");
        }
        public void RemovaVeiculo()
        {
            if (VeiculosCadastrados.Count == 0)
            {
                Console.WriteLine("Você não tem nenhum veículo cadastrado, logo não tem como remover!");
            }
            else
            {
                for (int i = 0; i < VeiculosCadastrados.Count; i++)
                {
                    Console.WriteLine($"{i} - {VeiculosCadastrados[i].Modelo} | Ano {VeiculosCadastrados[i].Ano} ");
                }
                Console.WriteLine("Qual veículo deseja remover?");
                int escolha = int.Parse(Console.ReadLine());
                VeiculosCadastrados.Remove(VeiculosCadastrados[escolha]);
                Console.WriteLine("Veículo removido com sucesso!");
            }
        }
        public void ListarVeiculos()
        {
            if (VeiculosCadastrados.Count == 0)
            {
                Console.WriteLine("Você não tem nenhum veículo cadastrado!");
            }
            else
            {
                for (int i = 0; i < VeiculosCadastrados.Count; i++)
                {
                    Console.WriteLine($"{i} {VeiculosCadastrados[i].Modelo} | Marca {VeiculosCadastrados[i].Marca} | Ano {VeiculosCadastrados[i].Ano} | Valor Base {VeiculosCadastrados[i].ValorBase} reais");
                }
            }
        }
        public void FazerAluguel()
        {
            if (VeiculosCadastrados.Count == 0)
            {
                Console.WriteLine("Você não tem nenhum veículo cadastrado, logo não tem como fazer o aluguel!");
            }
            else
            {
                for (int i = 0; i < VeiculosCadastrados.Count; i++)
                {
                    Console.WriteLine($"{i} - {VeiculosCadastrados[i].Modelo} | Marca {VeiculosCadastrados[i].Marca} | Ano {VeiculosCadastrados[i].Ano} | Valor Base {VeiculosCadastrados[i].ValorBase} reais");
                }
                Console.WriteLine("Qual veículo deseja fazer o aluguel?");
                int escolha = int.Parse(Console.ReadLine());
                Console.WriteLine("""
                    Qual é o tipo de veículo?
                    1 - Carro
                    2 - Moto
                    3 - Caminhão
                    """);
                int opcoes = int.Parse(Console.ReadLine());
                Console.WriteLine("Por quantos dias?");
                int dias = int.Parse(Console.ReadLine());
                Veiculo veiculo = null;
                switch (opcoes)
                {
                    case 1:
                        veiculo = new Carro(VeiculosCadastrados[escolha].Modelo, VeiculosCadastrados[escolha].Marca, VeiculosCadastrados[escolha].Ano, VeiculosCadastrados[escolha].ValorBase);
                        break;
                    case 2:
                        veiculo = new Moto(VeiculosCadastrados[escolha].Modelo, VeiculosCadastrados[escolha].Marca, VeiculosCadastrados[escolha].Ano, VeiculosCadastrados[escolha].ValorBase);
                        break;
                    case 3:
                        veiculo = new Caminhao(VeiculosCadastrados[escolha].Modelo, VeiculosCadastrados[escolha].Marca, VeiculosCadastrados[escolha].Ano, VeiculosCadastrados[escolha].ValorBase);
                        break;
                    default:
                        Console.WriteLine("Opção não cadastrada!");
                        break;
                }
                Console.Clear();
                Console.WriteLine("Resumo do pedido:");
                Console.WriteLine($"{VeiculosCadastrados[escolha].Modelo} | Ano {VeiculosCadastrados[escolha].Ano} | Dias {dias}");
                Console.WriteLine($"Total de: {veiculo.CalcularAluguel(dias)} reais");
                Console.WriteLine("Obrigado por alugar!");
            }
        }
        public virtual double CalcularAluguel(int dias)
        {
            double totalDoAluguel = ValorBase * dias;
            return totalDoAluguel;
        }
    }
}