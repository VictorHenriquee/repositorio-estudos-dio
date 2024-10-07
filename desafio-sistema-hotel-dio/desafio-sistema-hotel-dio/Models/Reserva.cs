namespace desafio_sistema_hotel_dio.Models;
internal class Reserva
{
    public Reserva(List<Pessoa> hospedes, int diasReservados, Suite suite)
    {
        Hospedes = hospedes;
        DiasReservados = diasReservados;
        QuantidadeHospedes = hospedes.Count;
        Suite = suite;
        IdReserva = GerarIdReserva();
    }

    private List<Pessoa> _hospedes = new();
    public List<Pessoa> Hospedes
    {
        set
        {
            _hospedes = value;
        }

        get => _hospedes;
    }

    public string IdReserva { get; }
    public Suite Suite { get; }
    public int DiasReservados { get; }
    public int QuantidadeHospedes { get; }

    private string GerarIdReserva()
    {
        var random = new Random();

        string idReserva = $"#{random.Next(999)}";
        return idReserva;
    }
    public List<string> Retornarlistahospedes()
    {
        List<string> hospedesNomeSobrenome = new();

        foreach (Pessoa hospede in Hospedes)
        {
            hospedesNomeSobrenome.Add(hospede.NomeSobrenome);
        }

        return hospedesNomeSobrenome;
    }
}
