using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//mi aporte, en el cual implemento lo siguiente para hacer la calculadora

//while
//try catch
//switch
//if else

namespace paltziIfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sirve para tomar decisiones
            bool salir = false;
            while (!salir)
            {
                try
                {
                    int resultado = 0;
                    Console.WriteLine("ELIJA LA SIGUIENTE OPCIÓN");

                    Console.WriteLine("1. Hacer un calculo ");
                    Console.WriteLine("2. Salir");

                    int opcion = Convert.ToInt16(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("CALCULADORA PLATZI con IF");

                            Console.WriteLine("Seleccione del 1-4 el tipo de operacion a ejecutar: ");
                            Console.WriteLine("1. Suma");
                            Console.WriteLine("2. Resta");
                            Console.WriteLine("3. Multiplicación");
                            Console.WriteLine("4. División");

                            opcion = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Ingrese el primer valor a calcular: ");
                            int valor1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo valor a calcular: ");
                            int valor2 = Convert.ToInt32(Console.ReadLine());

                            if (opcion == 1)
                            {
                                resultado = valor1 + valor2;
                                Console.WriteLine("El resultado de la suma es de: " + resultado);
                            }
                            else if (opcion == 2)
                            {
                                resultado = valor1 - valor2;
                                Console.WriteLine("El resultado de la resta es de: " + resultado);
                            }
                            else if (opcion == 3)
                            {
                                resultado = valor1 * valor2;
                                Console.WriteLine("El resultado de la multiplicación es de: " + resultado);
                            }
                            else if (opcion == 4)
                            {
                                resultado = valor1 / valor2;
                                Console.WriteLine("El resultado de la división es de: " + resultado);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Salir de la aplicación.");
                            salir = true;
                            break;
                    }     
                }
                catch
                {
                    Console.WriteLine("Ingrese un valor correcto.");
                }
            }

        }
    }
}

//Console.WriteLine("CALCULADORA PLATZI con SWITCH CASE");

//Console.WriteLine("Seleccione del 1-4 el tipo de operacion a ejecutar: ");
//Console.WriteLine("1. Suma");
//Console.WriteLine("2. Resta");
//Console.WriteLine("3. Multiplicación");
//Console.WriteLine("4. División");
//Console.WriteLine("5. Salir");

//opcion = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine("Ingrese el primer valor a calcular: ");
//int valor1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ingrese el segundo valor a calcular: ");
//int valor2 = Convert.ToInt32(Console.ReadLine());

//switch (opcion)
//{
//    case 1:
//        Console.WriteLine("Haz seleccionado suma");
//        resultado = valor1 + valor2;
//        Console.WriteLine("El resultado de la suma es: "+resultado);
//        break;
//    case 2:
//        Console.WriteLine("Haz seleccionado resta");
//        resultado = valor1 - valor2;
//        Console.WriteLine("El resultado de la suma es: " + resultado);
//        break;
//    case 3:
//        Console.WriteLine("Haz seleccionado multiplicación");
//        resultado = valor1 * valor2;
//        Console.WriteLine("El resultado de la suma es: " + resultado);
//        break;
//    case 4:
//        Console.WriteLine("Haz seleccionado división");
//        resultado = valor1 / valor2;
//        Console.WriteLine("El resultado de la suma es: " + resultado);
//        break;
//    case 5:
//        Console.WriteLine("Salir de la aplicación");
//        salir = true;
//        break;
//}