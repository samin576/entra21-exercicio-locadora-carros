using AppLocadora;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Veiculo veiculo = new Veiculo();
                int opcao;
                do
                {
                    Menu();
                    opcao = int.Parse(Console.ReadLine());
                    Escolha(opcao, veiculo);
                    if (opcao != 5)
                    {
                        Console.WriteLine("--Digite ENTER para prosseguir--");
                        Console.ReadLine();
                        Console.Clear();
                    }
                } while (opcao != 5);
                Console.WriteLine("Muito obrigado e adeus!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Algo deu errado! Reinicie o programa! {e.Message}");
            }

        }
        static void Menu()
        {
            Console.WriteLine("""
                1 - Cadastrar novo veículo
                2 - Remova veículo
                3 - Listar veículos
                4 - Faça o aluguel
                5 - Sair
                """);
        }
        static void Escolha(int opcao, Veiculo veiculo)
        {
            switch (opcao)
            {
                case 1:
                    veiculo.CadastrarVeiculo();
                    break;
                case 2:
                    veiculo.RemovaVeiculo();
                    break;
                case 3:
                    veiculo.ListarVeiculos();
                    break;
                case 4:
                    veiculo.FazerAluguel();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Você não digitou uma opção válida!");
                    break;
            }
        }
    }
}