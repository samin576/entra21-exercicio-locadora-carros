namespace AppLocadora
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int escolha;
                do
                {
                    Veiculo veiculo = new Veiculo();
                    Menu();
                    escolha = int.Parse(Console.ReadLine());
                    Opcoes(escolha, veiculo);
                    if (escolha != 0)
                    {
                        Console.WriteLine("--Digite enter para continuar--");
                        Console.ReadLine();
                        Console.Clear();
                    }

                } while (escolha != 0);
                Console.WriteLine("Adeus!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ops! Reinicie o programa! {ex.Message}");
            }
        }
        static public void Menu()
        {
            Console.WriteLine("""
                1 - Cadastrar veículo
                2 - Listar veículos
                3 - Fazer aluguel
                0 - Sair
                """);
        }
        static public void Opcoes(int escolha, Veiculo veiculo)
        {
            Console.Clear();
            switch (escolha)
            {
                case 0:
                    break;
                case 1:
                    veiculo.CadastrarVeiculo();
                    break;
                case 2:
                    veiculo.ListarVeiculos();
                    break;
                case 3:
                    veiculo.FazerAluguel();
                    break;
                default:
                    Console.WriteLine("Opção não válida!");
                    break;



            }
        }
    }

}