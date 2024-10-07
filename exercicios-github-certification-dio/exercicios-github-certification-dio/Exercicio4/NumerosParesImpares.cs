namespace exercicios_github_certification_dio.Exercicio4;
internal class NumerosParesImpares
{
    public int number { get; set; }

    public string VerificarParImpar(string stringNumber)
    {
        if (VerificarNumero(stringNumber))
        {
            if (number % 2 == 0)
                return "par";
            else
                return "impar";
        }
        else
        {
            Console.WriteLine("\nErro: Entrada inválida");
            return "";
        }
    }

    private bool VerificarNumero(string stringNumero)
    {
        if (int.TryParse(stringNumero, out int validatedNumber))
        {
            number = validatedNumber;
            return true;
        }
        else
        {
            number = 0;
            return false;
        }
    }
}
