using desafio_sistema_hotel_dio.Models;

namespace desafio_sistema_hotel_dio.Menu;
internal static class OpcoesMenu
{
    public static void MostrarOpcoes()
    {
        Console.WriteLine("""
            Escolha uma das opções abaixo: 
            
            1 - Realizar uma reserva
            2 - Realizar check-out
            3 - Mostrar Reservas
            4 - Sair
            """);
    }

    public static void RealizarReserva(Hotel hotel)
    {
        
        hotel.MostrarSuitesDisponiveis(); 

        Console.WriteLine("Digite o Id da suíte que deseja escolher: ");
        string idSuite = Console.ReadLine();

        (Suite? suite, bool verificacao) escolherSuite = hotel.EscolherSuite(idSuite);

        if (escolherSuite.verificacao)
        {
            List<Pessoa> hospedes = new();
            int cont = 1;

            Console.WriteLine($"Suíte {idSuite} escolhida com sucesso!");
            Console.WriteLine($"Essa suíte comporta até {escolherSuite.suite.Capacidade} pessoas");

            while (cont - 1 < escolherSuite.suite.Capacidade)
            {
                Console.Clear();
                Console.WriteLine($"Digite o nome do {cont}° hóspede: ");
                string? nome = Console.ReadLine();
                Console.WriteLine($"Digite o sobrenome do {cont}° hospede: ");
                string? sobrenome = Console.ReadLine();

                Pessoa pessoa = new(nome, sobrenome);
                hospedes.Add(pessoa);

                if (escolherSuite.suite.Capacidade == cont)
                    break;

                Console.WriteLine($"Deseja adicionar mais um hospede? S/N ({escolherSuite.suite.Capacidade - cont} hospedes restantes): ");
                char opcaoHospede = char.Parse(Console.ReadLine()!);

                if (opcaoHospede == 'n' || opcaoHospede == 'N')
                    break;
                cont++;
            }

            Console.WriteLine("Quandos dias serão reservados: ");
            int diasReservados = int.Parse(Console.ReadLine()!);

            Reserva reserva = new(hospedes, diasReservados, escolherSuite.suite);
            hotel.AdicionarReserva(reserva); 
        }
        else
        {
            Console.WriteLine($"ID {idSuite} inválida!");
        }
    }
    public static void RealizarCheckOut(Hotel hotel)
    {
        
        if (hotel.MostrarReservas())
        {
            Console.WriteLine("Escolha o ID de uma das reservas de cima: ");
            string idReserva = Console.ReadLine();

            (Reserva? reserva, bool verificacao) escolherReserva = hotel.EscolherReserva(idReserva);

            if (escolherReserva.verificacao)
            {
                decimal valorTotal = hotel.RealizarCheckOut(escolherReserva.reserva);

                Console.WriteLine($"Checkout realizado com sucesso! Valor a ser pago {valorTotal:C}");
                Thread.Sleep(2000);
            }
        }
    }
    public static void MostrarReservas(Hotel hotel)
    {

        hotel.MostrarReservas();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
    public static void Sair()
    {
        Console.WriteLine("Obrigado por utilizar nosso sistema!");
        Thread.Sleep(2000);
        Environment.Exit(0);
    }
}
