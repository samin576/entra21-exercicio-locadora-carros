namespace AppLocadora
{
    public class Veiculo : IVeiculo
    {
        private string _modelo;
        private string _marca;
        private int _ano;
        private double _precoBase;
        public string Modelo
        {
            get { return _modelo; }
            set
            {
                _modelo = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Opção inválida!");
            }
        }
        public string Marca
        {
            get { return _marca; }
            set { _marca = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Opção inválida!"); }
        }
        public int Ano
        {
            get { return _ano; }
            set { _ano = value > 0 ? value : throw new ArgumentException("Ano deve ser maior que 0!"); }
        }
        public double PrecoBase
        {
            get { return _precoBase; }
            set { _precoBase = value > 0 ? value : throw new ArgumentException("Preço deve ser maior que 0!"); }
        }

        public Veiculo() { }
        public Veiculo(string modelo, string marca, int ano, double precoBase)
        {
            _modelo = modelo;
            _marca = marca;
            _ano = ano;
            _precoBase = precoBase;
        }
        static List<Veiculo> listVeiculos = new List<Veiculo>();
        static List<Veiculo> listCarros = new List<Veiculo>();
        static List<Veiculo> listMotos = new List<Veiculo>();
        static List<Veiculo> listCaminhoes = new List<Veiculo>();

        public void CadastrarVeiculo()
        {
            Veiculo veiculo = new Veiculo();
            Console.WriteLine("""
                1 - Carro
                2 - Moto
                3 - Caminhão
                4 - Cancelar operação
                """);
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 4)
            {
                Console.WriteLine("Operação cancelada!");
                return;
            }
            Console.WriteLine("Nome do veículo:");
            veiculo.Modelo = Console.ReadLine();
            Console.WriteLine("Marca do veículo:");
            veiculo.Marca = Console.ReadLine();
            Console.WriteLine("Ano do veículo:");
            veiculo.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço base do veículo:");
            veiculo.PrecoBase = double.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    listCarros.Add(new Carro(veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.PrecoBase));
                    listVeiculos.Add(new Carro(veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.PrecoBase));
                    Console.WriteLine("Operação terminada!");
                    break;
                case 2:
                    listMotos.Add(new Moto(veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.PrecoBase));
                    listVeiculos.Add(new Moto(veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.PrecoBase));
                    Console.WriteLine("Operação terminada!");
                    break;
                case 3:
                    listCaminhoes.Add(new Caminhao(veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.PrecoBase));
                    listVeiculos.Add(new Caminhao(veiculo.Modelo, veiculo.Marca, veiculo.Ano, veiculo.PrecoBase));
                    Console.WriteLine("Operação terminada!");
                    break;
                default:
                    Console.WriteLine("Opção não válida!");
                    break;
            }
        }
        public void ListarVeiculos()
        {
            Console.WriteLine("""
                1 - Carros
                2 - Motos
                3 - Caminhões
                4 - Todos os veículos
                5 - Cancelar operação
                """);
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    if (listCarros.Count == 0)
                    {
                        Console.WriteLine("Não tem nenhum carro cadastrado!");
                    }
                    else
                    {
                        for (int i = 0; i < listCarros.Count; i++)
                        {
                            Console.WriteLine($"{listCarros[i].Modelo} | Marca {listCarros[i].Marca} | Ano {listCarros[i].Ano} | Valor base: {listCarros[i].PrecoBase} reais");
                        }
                    }
                    break;
                case 2:
                    if (listMotos.Count == 0)
                    {
                        Console.WriteLine("Não tem motos cadastradas!");
                    }
                    else
                    {
                        for (int i = 0; i < listMotos.Count; i++)
                        {
                            Console.WriteLine($"{listMotos[i].Modelo} | Marca {listMotos[i].Marca} | Ano {listMotos[i].Ano} | Valor base: {listMotos[i].PrecoBase} reais");
                        }
                    }
                    break;
                case 3:
                    if (listCaminhoes.Count == 0)
                    {
                        Console.WriteLine("Não tem caminhões cadastrados!");
                    }
                    else
                    {
                        for (int i = 0; i < listCaminhoes.Count; i++)
                        {
                            Console.WriteLine($"{listCaminhoes[i].Modelo} | Marca {listCaminhoes[i].Marca} | Ano {listCaminhoes[i].Ano} | Valor base: {listCaminhoes[i].PrecoBase} reais");
                        }
                    }
                    break;
                case 4:
                    if (listVeiculos.Count == 0)
                    {
                        Console.WriteLine("Não tem nenhum veículo cadastrado!");
                    }
                    else
                    {
                        for (int i = 0; i < listVeiculos.Count; i++)
                        {
                            Console.WriteLine($"{listVeiculos[i].Modelo} | Marca  {listVeiculos[i].Marca}  | Ano  {listVeiculos[i].Ano}  | Valor base: {listVeiculos[i].PrecoBase} reais");
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Operação cancelada!");
                    break;
                default:
                    Console.WriteLine("Opção não válida!");
                    break;
            }
        }
        public void FazerAluguel()
        {
            Console.WriteLine("""
                1 - Carros
                2 - Motos
                3 - Caminhões
                4 - Cancelar operação
                """);
            int escolha = int.Parse(Console.ReadLine());
            int escolhaVeiculo;
            switch (escolha)
            {
                case 1:
                    if (listCarros.Count == 0)
                    {
                        Console.WriteLine("Não tem nenhum carro cadastrado!");
                    }
                    else
                    {
                        for (int i = 0; i < listCarros.Count; i++)
                        {
                            Console.WriteLine($"{i} - {listCarros[i].Modelo} | Marca {listCarros[i].Marca} | Ano {listCarros[i].Ano} | Valor base: {listCarros[i].PrecoBase} reais");
                        }
                        escolhaVeiculo = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O total é de {listCarros[escolhaVeiculo].CalcularAluguel(listCarros[escolhaVeiculo].PrecoBase)} reais");
                    }
                    break;
                case 2:
                    if (listMotos.Count == 0)
                    {
                        Console.WriteLine("Não tem motos cadastradas!");
                    }
                    else
                    {
                        for (int i = 0; i < listMotos.Count; i++)
                        {
                            Console.WriteLine($"{i} - {listMotos[i].Modelo} | Marca {listMotos[i].Marca} | Ano {listMotos[i].Ano} | Valor base: {listMotos[i].PrecoBase} reais");
                        }
                        escolhaVeiculo = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O total é de {listMotos[escolhaVeiculo].CalcularAluguel(listMotos[escolhaVeiculo].PrecoBase)} reais");

                    }
                    break;
                case 3:
                    if (listCaminhoes.Count == 0)
                    {
                        Console.WriteLine("Não tem caminhões cadastrados!");
                    }
                    else
                    {
                        for (int i = 0; i < listCaminhoes.Count; i++)
                        {
                            Console.WriteLine($"{i} - {listCaminhoes[i].Modelo}  | Marca  {listCaminhoes[i].Marca}  | Ano  {listCaminhoes[i].Ano}  | Valor base: {listCaminhoes[i].PrecoBase} reais");
                        }
                        escolhaVeiculo = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O total é de {listCaminhoes[escolhaVeiculo].CalcularAluguel(listCaminhoes[escolhaVeiculo].PrecoBase)} reais");
                    }
                    break;
                case 4:
                    Console.WriteLine("Operação cancelada!");
                    break;
                default:
                    Console.WriteLine("Comando não entendido! Desculpa =(");
                    break;
            }
        }
        public virtual double CalcularAluguel(double precoBase)
        {
            Console.WriteLine("Seria por quantos dias?");
            int dias = int.Parse(Console.ReadLine());
            double total = dias * precoBase;
            return total;
        }
    }
}
