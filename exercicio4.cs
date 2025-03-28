  using System;

 public class Exercicio4
 {
     public static void Main(string[] args)
     {

        int idade = 68; 

         if ( idade < 18 )
         {
            Console.WriteLine("És menor de idade ");

         }
         else if(idade >=18 && idade <= 65)
         {
            Console.WriteLine("És adulto e solteiro ou és adulto e casado");

         }
         else
         {
            Console.WriteLine("És sénior");
         }
     }
        
 }    

