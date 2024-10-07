using desafio_sistema_estacionamento_dio.Models;

void PrecionarUmaTeclaParaContinuar()
{
    Console.WriteLine("\nPrecione uma tecla para continuar: ");
    Console.ReadKey();
}

Console.WriteLine("Seja bem vindo ao sistema de estacionamento");
Console.WriteLine("\nDigite o preço incial do estacionamento: ");
decimal precoInicial = decimal.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o preço por hora do estacionamento: ");
decimal precoPorHora = decimal.Parse(Console.ReadLine()!);

Estacionamento estacionamento = new(precoInicial, precoPorHora);

while (true)
{
    Console.Clear();
    Console.WriteLine("""
        Digite a sua opção:

        1 - Cadastrar veiculo
        2 - Remover veiculo
        3 - Listar veiculos
        4 - Sair
        """);

    int opcao = int.Parse(Console.ReadLine()!);

    switch(opcao)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Cadastro de veículo");

            Console.WriteLine("""
                Selecione o modelo da  placa do carro:

                1 - Placa Mercosul
                2 - Placa antiga
                """);
            int modeloPlaca = int.Parse(Console.ReadLine()!);

            Console.WriteLine("\nDigite a placa do veículo para estacionar: ");
            string placaVeiculoAdd = Console.ReadLine()!;

            Console.WriteLine(estacionamento.CadastrarVeiculo(placaVeiculoAdd, modeloPlaca));
            PrecionarUmaTeclaParaContinuar();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Remoção de veículo");
            Console.WriteLine("\nDigite a placa do veículo para remover: ");
            string placaVeiculoRem = Console.ReadLine()!;

            Console.WriteLine("\nDigite o tempo que o veículo ficou estacionado: ");
            int tempoCarroParadoEmHoras = int.Parse(Console.ReadLine()!);

            Console.WriteLine(estacionamento.RemoverVeiculo(placaVeiculoRem, tempoCarroParadoEmHoras));
            PrecionarUmaTeclaParaContinuar();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Lista de veículos");
            estacionamento.ListarVeiculos();
            PrecionarUmaTeclaParaContinuar();
            break;
        case 4:
            Console.WriteLine("Saindo do sistema de estacionamento...");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            Thread.Sleep(2000);
            break;
    }
}
