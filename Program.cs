using System;

namespace Divicion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Pedimos los datos y los guardamos en una variable
                Console.WriteLine("Ingrese el dividendo:");
                int dividendo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el divisor:");
                int divisor = int.Parse(Console.ReadLine());
                //Creamos un proceso segun lo necesitado
                if(divisor == 0)
                {
                    Console.WriteLine("El divisor no puede ser cero.");
                    return;
                }

                int cociente = dividendo / divisor;
                int residuo = dividendo % divisor;
                //Mostramos por pantalla el resultado
                Console.WriteLine($"Cociente: {cociente}");
                Console.WriteLine($"Residuo: {residuo}");
                Console.WriteLine("GRACIAS POR LA ESPERA");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
