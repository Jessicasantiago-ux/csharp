using System;

public class Exercicio8
{
    public static void Main(string[]args)
    {

        Console.WriteLine("Números pares entre 1 e 20");

        for ( int i = 1; i <= 20; i++ )
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
                
        }
        
    }
}
