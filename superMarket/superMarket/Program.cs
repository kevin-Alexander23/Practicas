using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;




namespace superMarket
{
    internal class Program
    {
        private static object areas;
        private static object categorias;
        private string Producto;

        static void Main(string[] args)
        {
            List<Categoria> categorias = new List<Categoria>();

            List<Area> areas = new List<Area>();
            List<Producto> productos = new List<Producto>();
            List<Compra> compras = new List<Compra>();

            Console.WriteLine("Bienvenido a la aplicación del Supermercado");
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1. Crear categoría");
                Console.WriteLine("2. Crear área");
                Console.WriteLine("3. Crear producto");
                Console.WriteLine("4. Registrar compra");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Categoria;
                        break;
                    case 2:
                        Area;
                        break;
                    case 3:
                        Producto;
                        break;

                    case 4:
                        Compra;
                        break;
                    case 5:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }

                Console.WriteLine();
            }



           
        }
        
      
        
       
    }

}
    

