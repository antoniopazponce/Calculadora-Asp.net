using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraUDIPractica
{
    public class Calculate
    {
        public int Suma(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public int Resta(int valor1 , int valor2)
        {
            return valor1 - valor2;
        }
        public int Multiplicacion(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        public int Division(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
    }
}