using System;

namespace BellaNapoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Bella Napoli");
            Console.WriteLine("==============================");
            Console.WriteLine("Todas nuestras pizzas llevan Tomate y Mozzarella.\n");

            Console.Write("¿Desea una pizza vegetariana? (s/n): ");
            string respuesta = Console.ReadLine().Trim().ToLower();

            bool esVegetariana;
            if (respuesta == "s")
                esVegetariana = true;
            else if (respuesta == "n")
                esVegetariana = false;
            else
            {
                Console.WriteLine("Opción no válida. Se asumirá 'no vegetariana'.");
                esVegetariana = false;
            }

            string[] ingredientesExtra;
            if (esVegetariana)
            {
                Console.WriteLine("\n🌿 Menú Vegetariano - Ingredientes disponibles:");
                Console.WriteLine("  1. Pimiento");
                Console.WriteLine("  2. Tofu");
                ingredientesExtra = new string[] { "Pimiento", "Tofu" };
            }
            else
            {
                Console.WriteLine("\nMenú No Vegetariano - Ingredientes disponibles:");
                Console.WriteLine("  1. Peperoni");
                Console.WriteLine("  2. Jamón");
                Console.WriteLine("  3. Salmón");
                ingredientesExtra = new string[] { "Peperoni", "Jamón", "Salmón" };
            }

            Console.Write("\nElija un ingrediente adicional (escriba el número): ");
            string seleccion = Console.ReadLine();
            int indice;

            while (!int.TryParse(seleccion, out indice) || 
                   indice < 1 || 
                   indice > ingredientesExtra.Length)
            {
                Console.Write($"Ingrese un número entre 1 y {ingredientesExtra.Length}: ");
                seleccion = Console.ReadLine();
            }

            string ingredienteElegido = ingredientesExtra[indice - 1];

            Console.WriteLine("\n**RESUMEN DE SU PEDIDO**");
            Console.WriteLine("==============================");
            Console.WriteLine($"Tipo de pizza: {(esVegetariana ? "Vegetariana" : "No vegetariana")}");
            Console.WriteLine($"Ingredientes: Tomate, Mozzarella, {ingredienteElegido}.");
            Console.WriteLine("\n¡Gracias por pedir en Bella Napoli!");
        }
    }
}