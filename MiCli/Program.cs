using System;

namespace BellaNapoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Bienvenido a Bella Napoli 1");
            Console.WriteLine("=================================");

            int tipo = 0;
            bool esVegetariana = false;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.WriteLine("\n¿Qué tipo de pizza desea?");
                Console.WriteLine("1. Vegetariana");
                Console.WriteLine("2. No vegetariana");
                Console.Write("Seleccione una opción (1 o 2): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out tipo) && (tipo == 1 || tipo == 2))
                {
                    esVegetariana = (tipo == 1);
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine(" Opción inválida. Intente de nuevo.");
                }
            }

            Console.WriteLine("\n--- Ingredientes disponibles ---");
            string[] ingredientes;
            if (esVegetariana)
            {
                Console.WriteLine("Pizza vegetariana:");
                Console.WriteLine("  1.  Pimiento");
                Console.WriteLine("  2.  Tofu");
                ingredientes = new string[] { "Pimiento", "Tofu" };
            }
            else
            {
                Console.WriteLine("Pizza no vegetariana:");
                Console.WriteLine("  1.  Peperoni");
                Console.WriteLine("  2.  Jamón");
                Console.WriteLine("  3.  Salmón");
                ingredientes = new string[] { "Peperoni", "Jamón", "Salmón" };
            }

            int seleccion = 0;
            entradaValida = false;
            while (!entradaValida)
            {
                Console.Write("\nElija un solo ingrediente adicional (número): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out seleccion) &&
                    seleccion >= 1 &&
                    seleccion <= ingredientes.Length)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine($" Opción inválida. Debe ser un número entre 1 y {ingredientes.Length}.");
                }
            }

            string ingredienteElegido = ingredientes[seleccion - 1];
            string tipoPizza = esVegetariana ? "vegetariana" : "no vegetariana";

            Console.WriteLine("\n  **RESUMEN DE SU PEDIDO** ");
            Console.WriteLine("=================================");
            Console.WriteLine($"Tipo de pizza: {tipoPizza}");
            Console.WriteLine("Ingredientes base: Tomate, Mozzarella");
            Console.WriteLine($"Ingrediente adicional: {ingredienteElegido}");
            Console.WriteLine("\n ¡Su pizza está en camino! Gracias por elegir Bella Napoli.");
        }
    }
}