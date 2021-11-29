using System;

namespace Algoritmo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algoritmo 1 muy basico
            // Mostrar 10 veces la palabra que se ingrese por consola
            string palabra = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(palabra);
            }

            // Algoritmo 2 muy basico
            // Sumar dos numeros pedidos por consola
            static int Sumar(int num1, int num2)
            {
                return num1 + num2;
            }

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Sumar(num1,num2));

            // Algoritmo 3 basico
            // Imprimir por consola los numeros ingresados de manera ascendente




        }
    }
}
