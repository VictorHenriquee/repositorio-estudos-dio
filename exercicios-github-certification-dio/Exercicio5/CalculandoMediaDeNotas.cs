namespace exercicios_github_certification_dio.Exercicio5;
internal class CalculandoMediaDeNotas
{
    public double nota1 { get; set; }
    public double nota2 { get; set; }
    public double nota3 { get; set; }

    public double CalcularMedia(string stringNota1, string stringNota2,string stringNota3)
    {
        if (ValidarNota(stringNota1, stringNota2, stringNota3))
        {
            double media = (nota1 + nota2 + nota3) / 3;
            return media;
        }
        else
        {
            Console.WriteLine("\nErro: Não foi possível calcular a média");
            return 0;
        }
    }

    private bool ValidarNota(string stringNota1, string stringNota2, string stringNota3)
    {
        if (double.TryParse(stringNota1, out double validatedNota1)
            && double.TryParse(stringNota2, out double validatedNota2)
            && double.TryParse(stringNota3, out double validatedNota3))
        {
            nota1 = validatedNota1;
            nota2 = validatedNota2;
            nota3 = validatedNota3;
            return true;
        }
        else
        {
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
            return false;
        }
    }
}
