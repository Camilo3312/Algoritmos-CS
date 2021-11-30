using System;
using System.Collections.Generic;

namespace Facil
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = OrderNumbers(new int[] { 5,4,3,3,5,1,4,5,2});
            Console.Write(response);
            Console.ReadLine();
        }

        //Mostrar los números del 1 hasta el número ingresado.
        public static string ShowNNumbers(int range)
        {
            string response = "";
            for (int i = 1; i <= range; i++)
            {
                response +=  $"{i} ";
            }
            return response;
        }

        // Ingresar dos números e intercambiarlos .
        public static string ToExchange(int num1, int num2)
        {
            int auxi;

            auxi = num1;
            num1 = num2;
            num2 = auxi;

            return $"{num1} {num2}";
        }

        //Ingresar un número y mostrar su cuadrado y cubo.
        public static string CalcCubic(int number)
        {
            string response = $"El cuadrado de {number} es {number * number} y el cubo es {number * number * number}";

            return response;
        }

        // Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) y mostrar por pantalla, el siguiente mensaje “Hola ” <nombre> ” bienvenido a ” <ciudad>
        public static void ShowText()
        {
            Console.WriteLine("Escribe tu nombre");
            String nombre = Console.ReadLine();

            Console.WriteLine("Escribe una ciudad");
            String ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " bienvenido a " + ciudad);
        }

        //  Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.
        public static void SumNumbers()
        {
            int a = 5;
            int b = 30;
            int c = 4;

            int suma = a + b + c;

            Console.WriteLine("La suma es " + suma);

            Console.ReadLine();
        }

        // Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: “Te llamas ” <nombre> ” y tienes ” <años> ” años”
        public static void ShowInfo()
        {
            Console.WriteLine("Escribe tu nombre");
            String nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu edad");
            String texto = Console.ReadLine();

            int edad = Convert.ToInt32(texto);

            Console.WriteLine("Nombre " + nombre + " y tienes " + edad + " años");
        }

        // Pedir dos números al usuario por teclado y decir que número es el mayor.
        public static void NumMinMax()
        {
            Console.WriteLine("Escribeme el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribeme el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("El primer numero es mayor o igual que el segundo");
            }
            else
            {
                Console.WriteLine("El segundo numero es mayor que el primero");
            }

        }

        // Pedir el nombre de la semana al usuario y decirle si es fin de semana o no.  En caso de error, indicarlo.
        public static void Weekdays()
        {
            Console.WriteLine("Escribe un dia de la semana");
            String dia = Console.ReadLine();

            switch (dia.ToLower())
            {

                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Es fin de semana");
                    break;

                default:
                    Console.WriteLine("Ese dia no es correcto");
                    break;
            }

        }

        // Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado)
        public static void Pay()
        {
            Console.WriteLine("Escribe el precio del producto");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe la forma de pago: tarjeta o efectivo");
            String forma = (Console.ReadLine()).ToLower();

            if (forma.Equals("tarjeta"))
            {

                Console.WriteLine("Introduce el numero de tarjeta");
                int numero_cuenta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El producto con precio " + precio + " se ha pagado " +
                "con el numero de cuenta " + numero_cuenta);


            }
            else if (forma.Equals("efectivo"))
            {

                Console.WriteLine("El producto con precio " + precio + " se ha pagado");

            }
            else
            {

                Console.WriteLine("La forma de pago no es correcta");
            }
        }

        // Recorre los números del 1 al 100. Usa un bucle for.
        public static void Loops()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Recorre los números del 1 al 100. Usa un bucle while.
        public static void LoopWhile()
        {
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        // Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.
        public static void Pairs()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        // Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.
        public static void DivisibleNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }

        //Ingresar un número y mostrar la suma de los números que lo anteceden.
        public static string SumNumbers(int range)
        {
            string response = "";
            int sum = 0;
            for (int i = 1; i <= range; i++)
            {
                response += $"{i} ";
                sum += i;
            }
            response = response + "= " + sum;
            return response;
        }

        //Mostrar los números primos entre el 0 y n.
        public static string PrimeNumbers(int range)
        {
            string response = "";
            for (int i = 1; i <= range; i++)
                if (i % 2 == 0)
                    response += $"{i} ";

            return response;
        }

        // Mostrar los nùmeros impares entre el 0 y el 100
        public static void OddNumbers()
        {
            int i, impar = 0;

            for (i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i}");
                    impar++;
                }
            }
        }

        //  Mostrar los multiplos de 3 del 0 al 100
        public static void Multiples()
        {
            for (int i = 0; i < 100; i++)
                if (i % 3 == 0)
                    Console.Write($"{i}| ");
        }

        //Ingresar n números sumar los positivos y multiplicar los negativos
        public static string PositivesNegatives(int[] numbers)
        {
            string response = "";
            int positiveNumber = 0;
            int negativeNumber = 1;
            foreach (var item in numbers)
                if (item < 0)
                {
                    negativeNumber = negativeNumber * item;
                }
                else
                {
                    positiveNumber = positiveNumber + item;
                }
            
            response = $"El resultado de los numeros positivos {positiveNumber} y los negativos {negativeNumber}";

            return response;
        }

        //Contar los multiplos de 3 desde la unidad hasta un num que ingresamos
        public static string Multiples(int range)
        {
            string response = "";

            int cont = 0;

            for (int i = 0; i < range; i++)
                if(i %3 == 0)
                {
                    cont++;
                }

            response = $"Entre el 1 y el {range} hay {cont} multiplos de 3";
            return response;
        }

        //Realizar la tabla de multiplicar de un número entre 0 y 10 de forma que se visualice de la siguiente forma: 4x1=4
        public static string MultiplicationTables(int number)
        {
            string response = "";
            for (int i = 1; i <= 10; i++)   
                response +=  $"{number} x {i} = {number * i}\n";
           
            return response;
        }

        // Ingresar n números y mostrar su promedio
        public static string AverageNumbers(int[] numbers)
        {
            string response = "";

            int average = 0;
            foreach (var item in numbers)
            {
                average += item;
            }
            response = $"El promedio de los valores ingresados es {average / numbers.Length}";

            return response;
        }

        // Recibir n numeros y ordernarlos de mayor a menor
        public static string OrderNumbers(int[] numbers)
        {
            string response = "";
            for (int i = 0; i < numbers.Length; i++)      
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int aux;
                    if (numbers[i] < numbers[j])
                    {
                        aux = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = aux;
                    }
                }
            
            foreach (var item in numbers)          
                response += $"{item} ";
            
            return response;
        }

        //Ingresar 3 datos y decir que clase de triangulo es.Para formar un triangulo hay que tener en cuenta que la suma de sus dos las inferiores tiene que ser mayor a el lado superior
        public static string ClassTriangle()
        {
            float[] lado = new float[3];
            float mayor = 0, sumar = 0;
            int i, j, auxi = 0, flag = 0;
            string response = "";

            for (i = 0; i < 3; i++)
            {
                Console.Write("Lado {0}:", i + 1);
                lado[i] = float.Parse(Console.ReadLine());

                if (lado[i] > mayor)
                {
                    mayor = lado[i];
                    auxi = i;
                }
            }

            for (i = 0; i < 3; i++)
                if (auxi != i)
                    sumar += lado[i];

            if (mayor < sumar)
            {
                response = "Es un triangulo \n";

                for (i = 0; i < 2; i++)
                    for (j = i + 1; j < 3; j++)
                        if (lado[i] == lado[j])
                            flag++;
                if (flag == 3)
                    response += "Es un triangulo \n";
                else
                {
                    flag = 0;
                    for (i = 0; i < 2; i++)
                        for (j = i + 1; j < 3; j++)
                            if (lado[i] != lado[j])
                                flag++;
                    if (flag == 3)
                        response += "Escaleno";
                    else
                        response += "Isosceles";

                }
            }
            else
            {
                response += "No es un triangulo";
            }
            return response;
        }

        // Dados 3 números donde el primero y el último son límites de un intervalo, indicar si el tercero pertenece a dicho intervalo
        public static string Interval()
        {
            float[] numero = new float[3];
            float mayor = 0, menor = 0;
            string response = "";

            int i, flag = 0, noingreso = 0;

            for (i = 0; i < 3; i++)
            {
                Console.Write("{0}º número:", i + 1);
                numero[i] = float.Parse(Console.ReadLine());

                if (flag == 0)
                {
                    mayor = numero[i];
                    menor = numero[i];
                    flag = 1;
                }
                else
                {
                    if (numero[i] > mayor)
                        mayor = numero[i];
                    if (numero[i] < menor)
                        menor = numero[i];
                }
            }

            for (i = 0; i < 3; i++)
            {
                if (numero[i] != mayor && numero[i] != menor)
                {
                    response = $"\nEl número {numero[i]} esta entre el {menor} y el {mayor}";
                    noingreso = 1;
                }
            }
            if (noingreso == 0)
                response = $"\nError.Hay numeros repetidos";

            return response;
        }

        // Ingresar 2 números, imprima los números naturales que hay entre ambos empezando por el más pequeño, contar cuántos números hay y cuántos de ellos son pares.
        public static string NaturalNumbers()
        {
            float num1, num2, menor, mayor;
            int i, cont = 0, contpar = 0;
            string response = "";

            do
            {
                Console.Write("Número 1:");
                num1 = float.Parse(Console.ReadLine());

                Console.Write("Número 2:");
                num2 = float.Parse(Console.ReadLine());
            } while (num1 == num2);

            if (num1 < num2)
            {
                menor = num1;
                mayor = num2;
            }
            else
            {
                menor = num2;
                mayor = num1;
            }

            for (i = (int)menor + 1; i < mayor; i++)
            {
                Console.Write($"{i}|");
                cont++;
                if (i % 2 == 0)
                    contpar++;
            }
            if (num1 == num2 - 1 || num2 == num1 - 1)
                response += $"\n\nNo hay numeros enteros entre {num1} y el {num2}";
            else
                response += $"\n\nEntre {menor} y {mayor} hay {cont} números de los cuales {contpar} son pares";

            return response;
        }

        // Se registran 10 empleados de una empresa Número de legajo, sueldo, sexo(1=femenino y 2=masculino).Mostrar cuantas mujeres ganan más de $500 pesos y cuantos hombres ganan menos de $400.
        public static string CalcValues()
        {          
            string response = "";

            string[] legajo = new string[10];
            float[] sueldo = new float[10];
            int[] op = new int[10];
            int i;


            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}º persona");
                Console.Write("Sueldo:");
                sueldo[i] = float.Parse(Console.ReadLine());
                Console.Write("Legajo:");
                legajo[i] = Console.ReadLine();
                Console.Write("1 = Femenino, 2 = Masculino:");
                op[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                if (op[i] == 1 && sueldo[i] > 500 || op[i] == 2 && sueldo[i] < 400)
                    response += $"Legajo: {legajo[i]}|Sexo: {op[i]}|Sueldo: {sueldo[i]}";
            }

            return response;
        }

        // Se ingresa por teclado la cantidad de agua caida, en mílimetros día a día durante un mes.Se pide determinar el día de mayor lluvia, el de menor y el promedio.
        public static void CalcDayRain()
        {

            int flag = 0, i = 0, mayordia = 0, menordia = 0, x = 30;
            int[] dia = new int[31];
            float menor = 0, mayor = 0, promedio = 0, contagua = 0;
            float[] agua = new float[x + 1];


            do
            {
                Console.Write("Ingrese dia:");
                dia[i] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese agua caida:");
                agua[i] = float.Parse(Console.ReadLine());

                if (flag == 0)
                {
                    mayordia = dia[i];
                    menordia = dia[i];
                    mayor = agua[i];
                    menor = agua[i];
                    flag = 1;
                }
                else
                {
                    if (agua[i] > mayor)
                    {
                        mayordia = dia[i];
                        mayor = agua[i];
                    }
                    if (agua[i] < menor)
                    {
                        menordia = dia[i];
                        menor = agua[i];
                    }
                }

                contagua += agua[i];

                if (i == 29)
                {
                    Console.Write("El mes tiene 31 dias s/n ?");
                    if (Console.ReadLine() == "s")
                        x = x + 1;
                }
                i++;
            } while (i < x);

            promedio = contagua / i;

            if (menor == mayor)
            {
                Console.Write("\nNo hubo mayor y menor dia de agua caida, fue igual para todos los dias {0}", menor);
            }
            else
            {
                Console.WriteLine("\nLa mayor cantidad de agua caida fue de {0} milímetros el/los dia/s ...", mayor);
                for (i = 0; i < x; i++)
                    if (agua[i] == mayor)
                        Console.Write("\nDia {0}", dia[i]);

                Console.WriteLine("\n\nLa menor cantidad de agua caida fue de {0} milímetros el/los dia/s ...", menor);
                for (i = 0; i < x; i++)
                    if (agua[i] == menor)
                        Console.Write("\nDia {0}", dia[i]);
            }
            Console.WriteLine("\n\nEl promedio de agua caida en {0} dias es {1}", x, promedio);
        }

        // Hacer el algoritmo que imprima el mayor y el menor de una serie de 5 números que vamos introduciendo por teclado.
        public static void MaxMinNumbers()
        {
            float[] num = new float[5];
            float mayor = 0, menor = 0;
            int flag = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese {0}º número:", i + 1);
                num[i] = float.Parse(Console.ReadLine());

                if (flag == 0)
                {
                    mayor = num[i];
                    menor = num[i];
                    flag = 1;
                }
                else
                {
                    if (num[i] > mayor)
                        mayor = num[i];
                    if (num[i] < menor)
                        menor = num[i];
                }
            }
            if (mayor == menor)
                Console.Write("\nLos números son todos iguales\n");
            else
                Console.Write("\nEl menor de los 5 números es el {0} y el mayor es el {1}", menor, mayor);

        }

        // Ingresar x cant de pesos y mostrar la cantidad de personas que pesan + de 80 y - de 80.
        public static void Weight()
        {
            float cont, men0, may0, num1;
            cont = 0;
            men0 = 0;
            may0 = 0;
            do
            {
                Console.Write("\nIngrese peso:");
                num1 = float.Parse(Console.ReadLine());

                if (num1 > 0)
                {
                    if (num1 <= 80)
                        men0 = men0 + 1;
                    if (num1 > 80)
                        may0 = may0 + 1;

                    cont++;
                }
                else
                    Console.Write("\nDebe ingresar mayor a 0\n");

                Console.Write("\nDesea continuar s/n ?");
            } while (Console.ReadLine() == "s");
            Console.Write("\n\nDe {0} persona/s {1} pesan menos o igual a 80 y {2} pesan mas de 80", cont, men0, may0);
            Console.Read();
        }

        // Por teclado se ingresa el valor hora de un empleado.Posteriormente se ingresa el nombre del empleado, la antiguedad y la cantidad de horas trabajadas en el mes. Se pide calcula
        // el importe a cobrar teniendo en cuenta que al total que resuelta de multiplicar el valor hora por la cantidad de horas trabajadas, hay que sumarle la cantidad de años trabajados
        // multiplicados por $30, y al total de todas esas operaciones restarle el 13% en concepto de descuentos. Imprimir el recibo correspondiente con el nombre, la antiguedad, el valor
        // hora, el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar.
        public static string CalcPrice(string name, float valuehours, float antiquity, float hoursworked)
        {
            string response = "";
            response += $"Nombre: {name}";
            response += $"Antiguedad: {antiquity}";
            response += $"Valor hora: {valuehours}";
            response += $"Total a cobrar: {valuehours * hoursworked + antiquity * 30}";
            response += $"Total del descuento: {(valuehours * hoursworked + antiquity * 30) * 0.1}";
            response += $"Total con descuento: {((valuehours * hoursworked + antiquity * 30) - (valuehours * hoursworked + antiquity * 30) * 0.13)}";
            return response;
        }
   
    }
}