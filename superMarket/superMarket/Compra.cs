using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMarket
{
    internal class Compra
    {
         void RegistrarCompra()
        {
            Console.Write("Ingrese su ID de usuario: ");
            int idUsuario = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su nombre: ");
            string nombreUsuario = Console.ReadLine();
        }
    }
}