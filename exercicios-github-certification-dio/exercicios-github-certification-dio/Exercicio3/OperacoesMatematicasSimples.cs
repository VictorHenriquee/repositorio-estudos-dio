namespace exercicios_github_certification_dio.Exercicio3;
internal class OperacoesMatematicasSimples
{

    public int number1 { get; set; }
    public int number2 { get; set; }
    public char operador { get; set; }

    public double RealizarOperacao(string stringNumber1, string stringNumber2, string stringOperador)
    {
        if(VerificarEntradas(stringNumber1, stringNumber2, stringOperador))
        {
            switch (operador)
            {
                case '+':
                    return Somar(number1, number2);
                case '-':
                    return Subtrair(number1, number2);
                case '*':
                    return Multiplicar(number1, number2);
                case '/':
                    return Dividir(number1, number2);
                default:
                    Console.WriteLine($"\nError: {operador}");
                    Console.WriteLine("Operador inválido");
                    return 0;
            }
        } else
        {
            return 0;
        }
    }


    private double Somar(double number1, double number2)
    {
        double result = number1 + number2;
        return result;
    }

    private double Subtrair(double number1, double number2)
    {
        double result = number1 - number2;
        return result;
    }

    private double Multiplicar(double number1, double number2)
    {
        double result = number1 * number2;
        return result;
    }

    private double Dividir(double number1, double number2)
    {
        if (VerificarDivisão(number2))
        {
            double result = number1 / number2;
            return result;
        }
        else
        {
            return 0;
        }
    }


    private bool VerificarDivisão(double number2)
    {
        if (number2 != 0)
            return true;
        else
            return false;
    }

    private bool VerificarEntradas(string stringNumber1, string stringNumber2, string stringOperador)
    {
        if (int.TryParse(stringNumber1, out int validatedNumber1)
            && int.TryParse(stringNumber2, out int validatedNumber2)
            && stringOperador.Length == 1)
        {
            number1 = validatedNumber1;
            number2 = validatedNumber2;
            operador = stringOperador[0];
            return true;
        }
        else
        {
            number1 = 0;
            number2 = 0;
            return false;
        }
    }
}
