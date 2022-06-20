using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida y realiza la operacion entre num1 y num2 
        /// </summary>
        /// <param name="num1"> primer numero a operar </param>
        /// <param name="num2"> segundo numero a operar </param>
        /// <param name="operador"> operacion a realizar(+,-,* o /) </param>
        /// <returns> El resultado de la operacion o double.MinValue en caso de error </returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = Double.MinValue;
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    break;
            }
            return resultado;
        }


        /// <summary>
        /// Valida que el caracter ingresado sea +,-,* o /.
        /// </summary>
        /// <param name="operador"> caracter a validar </param>
        /// <returns>si esta entre las opciones lo retorna caso contrario retorna '+' </returns>
        private static char ValidarOperador(char operador)
        {
            if(operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                operador = '+';
            }
            return operador;
        }
    }
}
