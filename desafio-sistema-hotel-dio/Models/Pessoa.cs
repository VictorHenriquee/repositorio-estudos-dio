namespace desafio_sistema_hotel_dio.Models;
internal class Pessoa
{
    private string _nome;
    private string _sobrenome;
    private string _nomeSobrenome;

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        AtualizarNomeSobrenome();
    }

    public string Nome
    {
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                _nome = "unnamed";
            else
                _nome = value;

            AtualizarNomeSobrenome();
        }
    }

    public string Sobrenome
    {
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                _sobrenome = null;
            else
                _sobrenome = value;

            AtualizarNomeSobrenome();
        }
    }

    public string NomeSobrenome => _nomeSobrenome;
    

    private void AtualizarNomeSobrenome()
    {
        if (_sobrenome == null || _nome == "unnamed")
        {
            _nomeSobrenome = $"{_nome}";
        }
        else
        {
            _nomeSobrenome = $"{_nome} {_sobrenome}";
        }
    }
}
