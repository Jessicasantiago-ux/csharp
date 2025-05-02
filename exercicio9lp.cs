using System;

public class Exercicio9
{
    public static void Main(string[]args)
    {

        int soma = 0;
        {
            Console.WriteLine(" calculo da soma dos números ímpares entre 1 e 50 ");
        }
        for (int i =1; i <= 50; i++)
        {
            if ( i % 2 != 0)
            {
                soma += i;
            }
        }
        Console.WriteLine("A soma dos números ímpares entre 1 e 50 é :" + soma);
        
    }
}
