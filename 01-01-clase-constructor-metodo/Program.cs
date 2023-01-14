using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_clase_constructor_metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0;

            Console.WriteLine("Ingresa el primer valo: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo valo: ");
            y = Convert.ToDouble(Console.ReadLine());

            Operaciones op = new Operaciones(x, y);

            op.Suma();
            op.Visualizar();

            Console.ReadLine();
        }
    }
}
