using System;
//DAMOS UN INICIO
namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //PERDIMOS DATOS Y LO GUARDAMOS EN VARIABLES
                Console.WriteLine("---- Calculadora Científica ----");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Seno");
                Console.WriteLine("6. Coseno");
                Console.WriteLine("7. Tangente");
                Console.WriteLine("8. Raíz Cuadrada");
                Console.WriteLine("9. Potencia");
                Console.WriteLine("0. Salir");
                //PEDIMOS QUE ELIJAN UNA DE LAS OPCIONES 
                Console.Write("Elije una opción: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0) break;
                //CREAMOS LAS VARIABLES EN 0 PARA PODER GUARDAR LOS DATOS QUE INTRODUCIRA EL USUARIO
                double a = 0;
                double b = 0;
                //PEDIMOS LOS DATOS
                if (choice >= 1 && choice <= 4)
                {
                    Console.Write("Introduce el primer número: ");
                    a = double.Parse(Console.ReadLine());

                    Console.Write("Introduce el segundo número: ");
                    b = double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Introduce el número: ");
                    a = double.Parse(Console.ReadLine());
                }
                //CREAMOS LOS PROCESOS SEGUN LA OPCION U OPERACION QUE EL USuARIO ELIJA 
                //AL MISMO TIEMPO MOSTRAMOS LOS RESULTADOS SEGUN LO QUE EL USUARIO NECESITE
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {a * b}");
                        break;
                    case 4:
                        if (b != 0)
                            Console.WriteLine($"Resultado: {a / b}");
                        else
                            Console.WriteLine("División por cero no es válida.");
                        break;
                    case 5:
                        Console.WriteLine($"Resultado: {Math.Sin(a)}");
                        break;
                    case 6:
                        Console.WriteLine($"Resultado: {Math.Cos(a)}");
                        break;
                    case 7:
                        Console.WriteLine($"Resultado: {Math.Tan(a)}");
                        break;
                    case 8:
                        Console.WriteLine($"Resultado: {Math.Sqrt(a)}");
                        break;
                    case 9:
                        Console.Write("Introduce la potencia: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Math.Pow(a, b)}");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("-------------------------------\n");
                //DAMOS UN FIN Y UN REINCIO DEL PROGRAMA
            }
        }
    }
}
