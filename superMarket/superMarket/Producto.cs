using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMarket
{
    internal class Producto
    {
        public string nombre;
        public string proveedor;
        private double precio;
        private int unidades;
        private string categoria;
        private string area;
        private object productos;

        public Producto(string nombre, string proveedor, double precio, int unidades, string categoria, string area)
        {
            this.nombre = nombre;
            this.proveedor = proveedor;
            this.precio = precio;
            this.unidades = unidades;
            this.categoria = categoria;
            this.area = area;
        }
        void CrearProducto()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el proveedor del producto: ");
            string proveedor = Console.ReadLine();
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese las unidades del producto: ");
            int unidades = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la categoría del producto: ");
            string categoria = Console.ReadLine();
            Console.Write("Ingrese el área del producto: ");
            string area = Console.ReadLine();

            Producto producto = new Producto(nombre, proveedor, precio, unidades, categoria, area);
            producto.productos = nombre;
            Console.WriteLine($"Producto '{nombre}' creado exitosamente.");
        }
    }
}
