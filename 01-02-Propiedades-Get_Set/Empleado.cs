using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_Propiedades_Get_Set
{
    class Empleado
    {
        private double sueldo;
        private double impuesto;
        private double impuestode;

        public void Muestra()
        {
            Console.WriteLine("Sueldo={0}, impuesto={1}", sueldo, impuesto);
        }
        public double Sueldo
        {
            get { return sueldo; }
            set { 
                sueldo = value;

                //if (sueldo > 5000)
                //{
                //    sueldo = value;
                //}
                //else
                //{
                //    sueldo = 3000;
                //}

            }
        }
        public double Impuesto
        {
            get { return impuesto; }
        }
        public void Mutator(double pimpuesto)
        {
            impuestode = pimpuesto/100;
            impuesto = sueldo * impuestode;
        }
    }
}
