using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_Polimorfismo_Interfase
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperacion opOperaciones = new CResta();//el mecanismo de interfaz es parecido a el polimorfismo

            double a, b;
            char opcion=' ';
            string seguir = " ";
            while (seguir!="si")
            {


                Console.WriteLine("Ingresa dos numeros cuales quiera:");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Seleccione una letra divicion[d], Multiplicacion[m], Resta[r], Suma[s]");
                opcion = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("----------Calculado-----------------");

                if (opcion == 'r')
                    opOperaciones = new CResta();//accion polimorfica (opOperaciones) puede reaccionar de diferente forma

                if (opcion == 'm')
                    opOperaciones = new CMulti();

                if (opcion == 'd')
                    opOperaciones = new CDiv();

                if (opcion == 's')
                    opOperaciones = new CSuma();

                /*
                 trabajar en terminos del concepto operacion en lugar de un tema en concreto como suma, resta, multi, div
                 */

                opOperaciones.Calcular(a, b);
                opOperaciones.Mostrar();
                Console.WriteLine("Quiere salir de la calculadora: si/no");
                seguir = Console.ReadLine();

            }
            Console.ReadLine();
        }
    }
}
