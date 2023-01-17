﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_Polimorfismo_Interfase
{
    class CResta:IOperacion
    {
        private double r = 0;
        private ArrayList resultado = new ArrayList();

        //Metodo a implemetar
        public void Calcular(double a, double b)
        {
            r = a - b;
        }
        public void Mostrar()
        {
            Console.WriteLine("El resultado se la resta es {0}", r);
        }
        //Metodo propio de la clase
        public void MuestraResultado()
        {
            foreach (double r in resultado)
            {
                Console.WriteLine(r);
            }
        }
    }
}
