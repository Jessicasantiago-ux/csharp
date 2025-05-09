using System;

public class Exercicio14
{
    public static void Main(string[] args)
    {

        int resultado = MaiorMenor(10, 20);

        Console.WriteLine("o maior numero dos " + "dois: " + resultado);
    }

    static int  MaiorMenor(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1; 
        }
        else
        {
            return n2;
        }
   
    }
     

         


}
  
  