using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';

            switch(operador)
            {
                case '-':
                    retorno = '-';
                    break;

                case '*':
                    retorno = '*';
                    break;

                case '/':
                    retorno = '/';
                    break;
                default:
                    break;
            }

            return retorno;
        }
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno = double.MinValue;
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case '+':
                    retorno = num1 + num2;
                    break;

                case '-':
                    retorno = num1 - num2;
                    break;

                case '*':
                    retorno = num1 * num2;
                    break;

                case '/':
                    retorno = num1 / num2;
                    break;

                default:
                    break;
            }
            return retorno;
        }

    }
}
