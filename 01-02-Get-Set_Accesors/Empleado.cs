using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_Get_Set_Accesors
{
    class Empleado
    {
        private double sueldo;
        private double impuesto;
        private string impuestodel;

        public void set_sueldo(double psueldo)
        {
            sueldo = psueldo;
        }
        public double get_sueldo()
        {
            return sueldo;
        }
        public string get_impuesto()
        {
            impuestodel = "16%";
            return impuestodel;
        }
        private void mutator()
        {
            impuesto = sueldo * 0.16;
        }
        public void muestra()
        {
            mutator();
            Console.WriteLine("Empleado 0001 con un sueldo neto de={0}, tendria un impuesto de={1}", sueldo, impuesto);
        }
    }
}
