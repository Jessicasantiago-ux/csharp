using System;

public class Exercicio7
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a nota final do aluno de 0 á 20 :");

        int nota = 20;

        if( nota >= 18 && nota <= 20)
        {
            Console.WriteLine("Excelente");
        }
        else if( nota >= 14 &&  nota <= 17)
        {
            Console.WriteLine("Bom");
        }
        else if( nota >= 10 && nota <= 13)
        {
            Console.WriteLine("Suficiente");
        }
        else if( nota >= 0 && nota <= 9)
        {
            Console.WriteLine("Insuficiente");
        }
        else
        {
            Console.WriteLine("Nota inválida");
        }
    }
}
