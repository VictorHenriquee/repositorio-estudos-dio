namespace desafio_poo_smartphone_dio.Models;
internal abstract class Smartphone
{
    protected Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        _modelo = modelo;
        _Imei = imei;
        _memoria = memoria;
    }
    public string Numero { get; set; }

    private string _modelo;
    private string _Imei;
    private int _memoria;

    public abstract void InstalarAplicativo(string aplicativo);

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }
}
