namespace exercicios_github_certification_dio.Exercicio6;
internal class VerificacaoPalindromo
{
    public bool VerificarPalindromo(string value)
    {
        string stringInvertida = InverterString(value);

        if (value.Equals(stringInvertida))
            return true;
        else
            return false;
    }

    private string InverterString(string value)
    {
        string stringInvertida = "";

        for (int i = value.Length -1; i >= 0; i--)
        {
            stringInvertida += value[i];
        }

        return stringInvertida;
    }
}
