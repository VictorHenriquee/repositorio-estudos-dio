using desafio_sistema_hotel_dio.Models;
using desafio_sistema_hotel_dio.Menu;

Hotel hotel = new();
Console.WriteLine("Bem Vindo ao Hotel!");
Console.WriteLine("Reserva de quarto");

while (true)
{
    Console.Clear();
    OpcoesMenu.MostrarOpcoes();

    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Console.Clear();
            OpcoesMenu.RealizarReserva(hotel);
            break;

        case 2:
            Console.Clear();
            OpcoesMenu.RealizarCheckOut(hotel);
            break;

        case 3:
            Console.Clear();
            OpcoesMenu.MostrarReservas(hotel);
            break;

        case 4:
            OpcoesMenu.Sair();
            break;
    }
}