using System;
 public  class Exercicio6
 {
     public static void Main(string[] args)
     {
        Console.WriteLine("Digite a sua nota");

        int nota = 80;

        if (nota >= 90)
        {
            Console.WriteLine("A");// Excelente
        }
        else if (nota >= 80 && nota <= 89)
        {
            Console.WriteLine("B");// Muito bom
        }
        else if (nota >= 70 && nota <= 79)
        {
            Console.WriteLine("C");//  Bom
        }
        else if (nota >= 60 && nota <= 69)
        {
            Console.WriteLine("D"); // Precisa melhorar
        }
        else
        {
            Console.WriteLine("F - reprovado");
        }
            
        

     }
 }

