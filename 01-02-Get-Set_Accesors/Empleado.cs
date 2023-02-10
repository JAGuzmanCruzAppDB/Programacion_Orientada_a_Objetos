using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_02_Get_Set_Accesors
{
    class Empleado
    {
        private double sueldo;
        private double impuesto;
        private double impuestodel;
        private string log;

        public void set_sueldo(double psueldo)
        {
            if (psueldo<5000 || psueldo > 15000)
            {
                LogError("Sueldo ilegal " + psueldo.ToString());
            }
            else
            {
                sueldo = psueldo;
            }
        }
        public double get_sueldo()
        {
            return sueldo;
        }
        public double get_impuesto(string pPassword,double pimpuesto)
        {
            if (pPassword != "12345")
            {
                LogError("Contraseña ilegar");
                return 0.0;
            }
            else
            {
                impuestodel=pimpuesto/100;
                return impuestodel;
            }
            //impuestodel = "16%";
        }
        private void mutator()
        {
            impuesto = sueldo * impuestodel;
        }
        private void LogError(string mensaje)
        {
            log += mensaje + "\r\n";
        }
        
        public void muestra()
        {
            mutator();
            Console.WriteLine("Empleado 0001 con un sueldo neto de={0}, tendria un impuesto de={1}", sueldo, impuesto);
            Console.WriteLine(log); 
        }
    }
}
