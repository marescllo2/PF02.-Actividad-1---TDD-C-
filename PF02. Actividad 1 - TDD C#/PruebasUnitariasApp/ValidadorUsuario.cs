using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasUnitariasApp
{
    public class ValidadorUsuario
    {
        public static int CalcularFactorial(int n)
        {
            if (n < 0)
                return -1;

            int resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public static bool EsContrasenyaValida(string contrasenya)
        {
            if (string.IsNullOrEmpty(contrasenya))
                return false;

            if (contrasenya.Length < 8)
                return false;

            return contrasenya.Contains('#');
        }
    }
}
