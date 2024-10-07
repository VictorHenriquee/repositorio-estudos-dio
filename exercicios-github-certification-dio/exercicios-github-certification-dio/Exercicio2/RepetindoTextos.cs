using System.Runtime.CompilerServices;

namespace exercicios_github_certification_dio.Exercicio2;
internal class RepetindoTextos
{
    public int intValue { get; set; }

    public void RepetirString(string value, string stringIntValue)
    {
        if (VerificarInteiro(stringIntValue))
        {
            for (int i = 0; i < intValue; i++)
            {
                Console.WriteLine(value);
            }
        } else
        {
            Console.WriteLine("\nErro! Digite um número válido");
        }
    }

    private bool VerificarInteiro(string stringIntValue)
    {
        if (int.TryParse(stringIntValue, out int validatedIntValue))
        {
            intValue = validatedIntValue;
            return true;
        } else
        {
            intValue = 0;
            return false;
        }
    }
}
