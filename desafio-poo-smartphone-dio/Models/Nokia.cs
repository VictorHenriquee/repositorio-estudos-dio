namespace desafio_poo_smartphone_dio.Models;
internal class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
        
    }

    public override void InstalarAplicativo(string aplicativo)
    {
        Console.WriteLine($"Instalando o aplicativo {aplicativo} no Nokia...");
    }
}
