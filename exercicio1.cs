using System; // Importação do namespace padrão para entrada/saída

public class Exercicio1
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Digite dois números inteiros.");

        // declarar variaveis
        int numero1 = 10;
        int numero2 = 20;

        // Realiza as operações
        int soma = numero1 + numero2;
        int subtracao = numero1 - numero2;
        int multiplicacao = numero1 * numero2;
        int divisao = numero1 / numero2;
        int resto = numero1 % numero2;


        // Exibe os resultados
        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Subtração: " + subtracao);
        Console.WriteLine("Multiplicação: " + multiplicacao);
        Console.WriteLine("Divisão: " + divisao);
        Console.WriteLine("Resto: " + resto);



    }


}

