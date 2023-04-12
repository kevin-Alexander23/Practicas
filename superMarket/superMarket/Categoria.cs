using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMarket
{
    internal class Categoria
    {
        string categorias;
        string nombre;

        public Categoria(string nombre)
        {
            this.nombre = nombre;
        }

         public void CrearCategoria()
        {
            Console.Write("Ingrese el nombre de la categoría: ");
            string nombre = Console.ReadLine();
            Categoria categoria = new Categoria(nombre);
            categoria.categorias = nombre;
            Console.WriteLine($"Categoría '{nombre}' creada exitosamente.");
        }
    }
}
