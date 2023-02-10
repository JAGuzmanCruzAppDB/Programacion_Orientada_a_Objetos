using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_Get_Set_Accesors
{
    class Program
    {
        static void Main(string[] args)
        {
            string contra;
            double impuesto;
            Empleado juan = new Empleado();

            juan.set_sueldo(7800);
            contra = "12345";
            impuesto = 16;
            juan.get_impuesto(contra, impuesto);
            juan.muestra();

            Console.WriteLine("--------------------------");
            
            //Empleado jose = new Empleado();

            //jose.set_sueldo(50000);
            //jose.set_sueldo(25000);
            //jose.set_sueldo(10000);

            //Console.WriteLine("Esueldo de jose es {0}", jose.get_sueldo(56));

            //Console.WriteLine("Ingresa la contraseña");
            //contra = Console.ReadLine();
            //Console.WriteLine("Ingresa el impuesto a tomar en cuenta");
            //impuesto = 0.16;

            //Console.WriteLine("El impuesto tomado en cuenta es de " + em.get_impuesto(contra,impuesto));

            ////em.set_sueldo(1100);
            //em.set_sueldo(1100);

            //em.muestra();

            Console.ReadKey();
        }
    }
}
