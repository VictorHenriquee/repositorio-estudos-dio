namespace desafio_sistema_hotel_dio.Models;
internal class Suite
{
    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        IdSuite = GerarIdSuite();
        TipoSuite = tipoSuite;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }

    public string IdSuite { get; }
    public string TipoSuite { get; }
    public int Capacidade { get; }
    public decimal ValorDiaria { get; }


    private string GerarIdSuite()
    {
        var random = new Random();

        string idSuite = $"#{random.Next(999)}";
        return idSuite;
    }
}
