using System;

public class Exercicio16
{
    public static void Main(string[]args)
    {
        int numero = 10;

        int quadrado = numero * numero;

        if( numero % 2 == 0)
        {
            Console.WriteLine("O numero indicado é par e o seu quadrado é " + quadrado);
        }
        else
        {
            Console.WriteLine("O numero é ímpar.");
        }
    }
}
