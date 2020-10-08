using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dispensador;

namespace Dispensador
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Dispensadora dispensador = new Dispensadora();
                Console.WriteLine("bienvenidos");
                Console.WriteLine("1. agregar producto");
                Console.WriteLine("2. eliminar producto");
                Console.WriteLine("2. Comprar producto");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1";
                        Producto producto = new Producto();
                        Console.Write("codigo");
                        producto.codigo = Console.ReadLine();

                        Console.Write("Nombre");
                        producto.Nombre = Console.ReadLine();

                        Console.Write("Categoria");
                        producto.Categoria = Console.ReadLine();

                        Console.Write("Cantidad");
                        producto.Cantidad = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Valor");
                        producto.valor= double.Parse(Console.ReadLine());

                        dispesador.agregar(producto);
                        break;


                }
            }
        }
    }
}
