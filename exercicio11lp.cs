using System;

public class Exercicio11
{
    public static void Main(string[] args)
    {

        int soma = 0;
        int numero = 1;

        do
        {
            soma += numero;
            numero++;
        } while (soma < 100);

        Console.WriteLine("A soma acumulada é :" + soma);
        Console.WriteLine("O último número adicionado foi :" + (numero - 1));

    }
}
