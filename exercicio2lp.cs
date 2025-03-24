using System;

public class Exercicio2
{
    public static void Main(string[] args)
    {
        // Exibe uma mensagem inicial
        Console.WriteLine("O valor da  área de uma circunferência com o raio de 10.");

        // Declaração de variável e cálculo
        double raio = 14; // Valor do raio
        double area = 3.14 * raio * raio; // Fórmula para calcular a área (usando 3.14 para π)

        // Mostra o resultado
        Console.WriteLine("A área da circunferência é: " + area + " m²");
    }
}