using System;
  public class Exercicio5
  {
     public static void Main(string[] args)
     {
        Console.WriteLine("digite um númro de 1 á 7");
        int numero = 6;
        string dias;

        switch(numero)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-Feira");
                break;
            case 3:
                Console.WriteLine("Terça-Feira");
                break;
            case 4:
                Console.WriteLine("Quarta-Feira");
                break;
            case 5:
                Console.WriteLine("Quinta-Feira");
                break;
            case 6:
                Console.WriteLine("Sexta-Feira");
                break;
            case 7:
                Console.WriteLine("Sabado");
                break;
            default:
                Console.WriteLine("Número inválido! Introduz um número entre 1 e 7.");
                break;
 
        }
     }
  }

