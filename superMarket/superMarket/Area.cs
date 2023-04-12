using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace superMarket
{
    internal class Area
    {
        string nombre;
        string areas;

        public Area(string nombre)
        {
            this.nombre = nombre;
        }

        static void CrearArea()
        {
            Console.Write("Ingrese el nombre del área: ");
            string nombre = Console.ReadLine();
            Area area = new Area(nombre);
           area.areas = nombre;
            Console.WriteLine($"Área '{nombre}' creada exitosamente.");
        }
    }
}
