using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un catálogo de medicamentos
            Medicamento[] catalogo = {
                new Medicamento("Dolor de cabeza", "Aspirina", 20, "Pastilla", 500, new DateTime(2024, 1, 1)),
                new Medicamento("Gripe", "Jarabe para la tos", 10, "Jarabe", 250, new DateTime(2023, 12, 1)),
                new Medicamento("Fiebre", "Ibuprofeno", 15, "Pastilla", 200, new DateTime(2025, 5, 1)),
                new Medicamento("Dolor muscular", "Crema para el dolor", 8, "Pomada", 500, new DateTime(2022, 8, 1))
            };

            // Pedir al usuario que elija una enfermedad
            Console.WriteLine("¿Qué enfermedad tiene el cliente?");
            Console.WriteLine("1. Dolor de cabeza");
            Console.WriteLine("2. Gripe");
            Console.WriteLine("3. Fiebre");
            Console.WriteLine("4. Dolor muscular");
            int opcion = Convert.ToInt32(Console.ReadLine());

            // Mostrar los medicamentos disponibles para la enfermedad elegida
            Console.WriteLine("Estos son los medicamentos disponibles:");
            foreach (Medicamento medicamento in catalogo)
            {
                if (medicamento.Enfermedad == opcion)
                {
                    Console.WriteLine($"- {medicamento.Nombre} ({medicamento.Cantidad} unidades, {medicamento.Dosis} {medicamento.Unidad})");
                }
            }

            // Pedir al usuario que elija un medicamento
            Console.WriteLine("¿Qué medicamento desea comprar?");
            string nombre = Console.ReadLine();

            // Buscar el medicamento elegido en el catálogo
            Medicamento elegido = null;
            foreach (Medicamento medicamento in catalogo)
            {
                if (medicamento.Nombre == nombre)
                {
                    elegido = medicamento;
                    break;
                }
            }

            // Si no se encontró el medicamento, mostrar un mensaje y salir del programa
            if (elegido == null)
            {
                Console.WriteLine("Lo siento, no se encontró el medicamento especificado.");
                return;
            }

            // Pedir al usuario los datos del cliente
            Console.WriteLine("Ingrese los datos del cliente:");
            Console.Write("Nombre: ");
            string nombreCliente = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellidoCliente = Console.ReadLine();
            Console.Write("Dirección: ");
            string direccionCliente = Console.ReadLine();
            Console.Write("Teléfono: ");
            string telefonoCliente = Console.ReadLine();

            // Pedir al usuario la cantidad de unidades que desea comprar
            Console.WriteLine($"El precio por unidad de {elegido.Nombre} es de $10.");
            Console.Write("¿Cuántas unidades desea comprar? ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            
           

        }
    }
}
