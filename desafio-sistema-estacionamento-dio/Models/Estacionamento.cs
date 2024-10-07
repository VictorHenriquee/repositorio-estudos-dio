using System.Text.RegularExpressions;

namespace desafio_sistema_estacionamento_dio.Models;
internal class Estacionamento(decimal precoInicial, decimal precoPorHora)
{
    private decimal precoInicial = precoInicial;
    private decimal precoPorHora = precoPorHora;
    private List<string> veiculos = new();

    public string CadastrarVeiculo(string placaCarro, int modeloPlaca)
    {
        if (VerificarPlaca(placaCarro,modeloPlaca))
        {
            veiculos.Add(placaCarro);
            return $"O veículo {placaCarro} foi cadastrado com sucesso!";
        }
        else
        {
            return $"Erro. Placa {placaCarro} inválida";
        }
        

    }

    public string RemoverVeiculo(string placaCarro, int tempoCarroParadoEmHoras)
    {

        if (veiculos.Contains(placaCarro))
        {
            decimal precoTotal = CalcularPrecoTotal(tempoCarroParadoEmHoras);
            veiculos.Remove(placaCarro);

            return $"O veículo {placaCarro} foi removido e o preço total foi de {precoTotal} reais";
        }
        else
        {
            return $"O veículo com placa {placaCarro} não foi encontrado";
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Any())
        {
            foreach (string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
        else
        {
            Console.WriteLine("Nenhum veículo cadastrado");
        }
        
    }

    private decimal CalcularPrecoTotal(int tempoCarroParadoEmHoras)
    {
        decimal precoTotal = precoInicial + precoPorHora * tempoCarroParadoEmHoras;
        return precoTotal;
    }

    private bool VerificarPlaca(string placaCarro, int modelo)
    {
        switch (modelo)
        {
            case 1:
                // Modelo mercosul
                bool verificacaoMercosul = Regex.IsMatch(placaCarro, "^[A-Z]{3}\\d[A-Z]\\d{2}$");
                return verificacaoMercosul;
            case 2:
                // Modelo antigo
                bool verificacaoModeloAntigo = Regex.IsMatch(placaCarro, "^[A-Z]{3}-\\d{4}$");
                return verificacaoModeloAntigo;
        }
        return false;
    }
}
