<p align="center">
<span style="font-size: 25px"><strong>Resolvendo o desafio de exercícios da formação <i>Github Certification</i> da plataforma Dio</strong></span>
</p>

<p align="center">
	<span style="font-size: 28px;"><strong>Entendendo o desafio</strong></span>
</p>

<p align="center">
  <img src="https://i.giphy.com/media/v1.Y2lkPTc5MGI3NjExOGtxcHd6aW8yYTFuZWM5eWw0cnhsM2k2NGc4MWN3ZWZvNmRzeGRybSZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/3oEjHSuTCk0TBeLcGs/giphy-downsized.gif" width="440">
</p>

<p align="center">
	<span style="font-size: 19px;"><u>Neste desafio foram propostos 6 exercícios a serem resolvidos.</u></span>
</p>

1. **Concatenando Dados:** Dois dados diferentes serão recebidos do usuário. A missão é concatenar esses dados em uma string.
2. **Repetindo Textos:** Uma string e um número inteiro será solicitado como entrada. O objetivo é repetir essa string pelo número que foi informado.
3. **Operações Matemáticas Simples:** Dois números será solicitado como entrada, a partir deles, algumas operações simples deverá ser realizadas.
4. **Verificando Números Pares e Ímpares:** A partir de um número inteiro, deverá ser verificado se tal numero é par ou ímpar.
5. **Calculando Média De Notas:** Deverá ver calculado 3 notas recebidas pelo usuário.
6. **Verificando Palíndromos:** Deverá ser recebido uma string do usuário. Verifique se essa string é um palíndromo.


<p align="center">
	<span style="font-size: 28px;"><strong>Objetivos</strong></span>
</p>

<p align="center">
	O principal objetivo desse desafio além aprimorar meus conceitos na linguagem C# é exercitar meus conhecimentos nos comandos git. Além de treinar meus conhecimentos na linguagem de marcação Markdown.
</p>

<p align="center">
	<span style="font-size: 28px;"><strong>Resolvendo os exercícios!</strong></span>
</p>

### 1. Concatendo Dados ✅

```
internal class ConcatenandoDados()
{

    public string ConcatenarStrings(string value1, string value2)
    {
        string stringConcatenada = value1 + " " + value2;
        return stringConcatenada;
    }
}

```

Este Exercício foi relativamente simples. O método ConcatenarStrings recebe 2 strings. Essas 2 strings são concatenadas na variável concatenarStrings. Logo depois o método retorna essa variável.

### 2. Repetindo Textos ✅


Vamos por partes. Neste exercício foram criados 2 métodos. Vamos analizar o primeiro método
```
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
```

O objetivo do método acima é verificar se o número que o usuário passou é um número inteiro. Para isso será usado o método TryParse().
<br><br>
O método TryParse irá receber uma string, ele tentará converter essa string em um inteiro. Se essa operação for bem sucedida, ele retornará o valor booleano true e realocará esse número inteiro a variável passada no segundo argumento do método. Porém se a operação não for bem sucedida, ele retornará o valor booleano false. A variável passada o segundo argumento do método irá receber o valor 0.
<br><br>
Dito isso, o método acima VerificarInteiro irá retornar true e a propriedade da classe intValue irá receber o inteiro verificado melo TryParse() se o mesmo tiver a operação bem sucedida. Senão, o método retornará false e o valor 0 será atribuído a propriedade intValue.
<br><br>
Vamos analizar o segundo método
```
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
```
Este é o método principal, que irá receber os argumentos do usuário. Primeiro de tudo esse método vai verificar se o número recebido é um inteiro utilizando o VerificarInteiro().
<br><br>
Se for um inteiro, através do loop for, ele irá mostrar no console a string recebida repetidas pelo número inteiro recebido.
<br><br>
Se não for um inteiro, ele mostrará no console a mensagem o erro.
<br><br>
Veja o código completo
```
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

```

### 3. Operações matemáticas Simples ✅
Para resolver esse exercício decidi fazer as 4 operações básicas. Soma, divisão, multiplicação e divisão.
<br><br>
Primeiro criei 4 métodos paras as 4 operações básicas
```
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
```
Depois criei 2 métodos para validar dados
```
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
```
O primeiro VerificarDivisão() é para não permitir que o usuário multiplique um número por 0.
<br><br>
O segundo VerificarEntradas() estou utilizando o TryParse() para verificar as entradas e não permitir que o programa feche.
<br><br>
Por último criei o método para receber as entradas do usuário e usar os métodos anteriores para validar as entradas
```
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
```
O método acima recebe 2 números e um dos 4 operadores possíveis: '+', '-', '*', '/'. Se o usuário não digitar um dos 4 operadores uma mensagem de erro será exibida.
<br><br>
O código completo
```
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

```
### 4. Verificando Números Pares e Ímpares ✅
Nesse exercício criei novamente um método para validar entrada igual aos exercícios anteriores, e o método principal para receber os argumentos
```
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
```
### 5. Calculando média de notas ✅
Resolução do exercício
```
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

```
### 6. Verificando Palíndromos ✅
Nesse exercício criei um método para inverter a string recebida
```
private string InverterString(string value)
    {
        string stringInvertida = "";

        for (int i = value.Length -1; i >= 0; i--)
        {
            stringInvertida += value[i];
        }

        return stringInvertida;
    }
```
Dentro desse método usei um for para percorrer a string recebida de trás pra frente. Depois coloco essa nova string em uma variável.
<br><br>
Código completo
```
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

```

