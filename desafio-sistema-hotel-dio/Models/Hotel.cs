namespace desafio_sistema_hotel_dio.Models;
internal class Hotel
{
    private List<Reserva> _reservas = new();
    private List<Suite> _suitesDisponiveis = new()
    {
        new Suite("Gold", 4, 218),
        new Suite("Silver", 3, 104),
        new Suite("Bronze", 3, 83),
        new Suite("Economic", 2, 77),
        new Suite("Economic Plus", 1, 60),
    };
    private List<Suite> _suitesOcupadas = new();
    public int LotacaoHospedes => _reservas.Sum(x => x.QuantidadeHospedes);


    public (Suite?, bool) EscolherSuite(string idSuite)
    {
        foreach (Suite suite in _suitesDisponiveis)
        {
            if (suite.IdSuite.Trim() == idSuite)
            {
                _suitesDisponiveis.Remove(suite);
                _suitesOcupadas.Add(suite);
                return (suite, true);
            }
        }
        return (null, false);
    }

    public (Reserva?, bool) EscolherReserva(string idReserva)
    {
        foreach (Reserva reserva in _reservas)
        {
            if (reserva.IdReserva.Trim() == idReserva)
            {
                return (reserva, true);
            }
        }
        return (null, false);
    }


    public decimal RealizarCheckOut(Reserva reserva)
    {
        _suitesOcupadas.Remove(reserva.Suite);
        _suitesDisponiveis.Add(reserva.Suite);
        _reservas.Remove(reserva);
        return CalcularValorTotalReserva(reserva);
    }

    public void MostrarSuitesDisponiveis()
    {
        if (_suitesDisponiveis.Count == 0)
        {
            Console.WriteLine("Não há suítes disponíveis.");
        }
        else
        {
            Console.WriteLine("Suítes disponíveis:");
            foreach (Suite suite in _suitesDisponiveis)
            {
                Console.WriteLine($"ID: {suite.IdSuite}\n " +
                    $"Tipo: {suite.TipoSuite}\n " +
                    $"Capacidade: {suite.Capacidade}\n " +
                    $"Valor da diária: R${suite.ValorDiaria}");
                Console.WriteLine("---------------------------------------------");
            }
        }
    }

    public bool MostrarReservas()
    {
        if (_reservas.Count == 0)
        {
            Console.WriteLine("Não há reservas.");
            return false;
        }
        else
        {
            
            Console.WriteLine("Reservas:");
            foreach (Reserva reserva in _reservas)
            {
                List<string> hospedeNomeSobrenome = reserva.Retornarlistahospedes();

                Console.WriteLine($"Id da Reserva: {reserva.IdReserva}\n" +
                    $"Hóspedes: {string.Join(", ", hospedeNomeSobrenome)}\n" +
                    $"Dias reservados: {reserva.DiasReservados}\n" +
                    $"Valor total: {CalcularValorTotalReserva(reserva):C}");
                Console.WriteLine("-------------------------------------------------");
            }

            return true;
        }
    }

    public void AdicionarReserva(Reserva reserva)
    {
        _reservas.Add(reserva);
    }

    private decimal CalcularValorTotalReserva(Reserva reserva)
    {
        decimal valorReserva = reserva.DiasReservados * reserva.Suite.ValorDiaria;

        if (reserva.DiasReservados >= 10)
        {
            decimal desconto = (valorReserva * 10) / 100;
            return valorReserva - desconto;
        }

        return valorReserva;
    }
}