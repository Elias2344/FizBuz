using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //primera -  inicializacion
            //antes de comenzar el for

            //segunda - condicion
            //Antes de comenzar cada iteracion del for

            //tercera - ???
            //Despues de cada iteracion
            
            //while (ture) {

            //}
            //Incrementar
            //int = i + 1
            //i++;

            //Decrementar
            //i = i - 1
            //i --;

            for (int i=1; i <= 100;i ++)
            if (i % 3 == 0 && i % 5 == 0){
                 Console.WriteLine("FizzBuzz");
            }else if (i % 3 == 0){
                Console.WriteLine("Fizz");
            }else if (i % 5 == 0){
                Console.WriteLine("Buzz");
            }else{
                Console.WriteLine(i);
            }
           

            //En enteros
            //3/3 =1
            //4/3 =1

            //En decimales
            //3/33 = 1.0
            //4/3 = 1.33

            //Modulo (%)
            //3 % 3 = 0
            //4 % 3 = 1


        }
    }
}
