using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        /// <summary>
        /// Constructor sin parametros de Operando
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Constructor de Operando
        /// </summary>
        /// <param name="numero"> numero que tomara this.numero </param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor de Operando que recibe un string y lo transforma a double
        /// </summary>
        /// <param name="strNumero"> numero a almacenar en this.numero </param>
        public Operando(string strNumero)
        {
            double numero;
            if(double.TryParse(strNumero, out numero))
            {
                this.numero = double.Parse(strNumero);
            }
        }

        /// <summary>
        /// comprobara que el valor recibido sea numerico.
        /// </summary>
        /// <param name="strNumero"> numero a validar </param>
        /// <returns> Retorna el valor de ser numerico o caso contrario retornara 0 </returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;
            double numero;
            if(double.TryParse(strNumero, out numero))
            {
                retorno = numero;
            }
            return retorno;
        }

        /// <summary>
        /// Valida y settea el valor de numero solo si es valido
        /// </summary>
        public string Numero
        {
            set
            {
                double validar;
                validar = ValidarOperando(value);
                if(validar!=0)
                {
                    this.numero = validar;
                }
            }
        }

        /// <summary>
        /// valida que la cadena de caracteres este compuesta solo de 0 y 1.
        /// </summary>
        /// <param name="binario"> cadena a validar </param>
        /// <returns> retorna false en caso de no ser numero binario o caso contrario retorna true </returns>
        private static bool EsBinario(string binario)
        {
            bool validar = true;
            foreach (char c in binario) 
            {
                if (c != '0' && c != '1')
                {
                    validar = false;
                }
            }
            return validar; 
        }


        /// <summary>
        /// Convierte la cadena ingresada de Binario a decimal
        /// </summary>
        /// <param name="binario"> cadena a convertir </param>
        /// <returns> retorna la cadena en formato decimal o en caso de error retorna "Valor inválido" </returns>
        public static string BinarioDecimal(string binario)
        {
            string retorno = string.Empty;
            if(EsBinario(binario))
            {
                double resultado = 0;
                int cantidadCaracteres = binario.Length;
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;
                    if (caracter == '1')
                    {
                        resultado += (int)Math.Pow(2, cantidadCaracteres);
                    }
                }
                retorno = resultado.ToString();
            }
            else
            {
                retorno = "Valor inválido";
            }
            return retorno;
        }


        /// <summary>
        /// Convierte la cadena ingresada de decimal a binario
        /// </summary>
        /// <param name="numero"> cadena a convertir </param>
        /// <returns> retorna el numero en formato binario o en caso de error retornara "Valor inválido" </returns>
        public static string DecimalBinario(double numero)
        {
            string retorno = string.Empty;
            if(numero%1 == 0)
            {
                if(numero<0)
                {
                    numero *= -1;
                }
                int resultadoDivision = Convert.ToInt32(numero);
                int restoDivision;
                if (resultadoDivision >= 0)
                {
                    do
                    {
                        restoDivision = resultadoDivision % 2;
                        resultadoDivision /= 2;
                        retorno = restoDivision.ToString() + retorno;
                    } while (resultadoDivision > 0);
                }
                else
                {
                    retorno = "Valor inválido";
                }
            }
            else
            {
                retorno = "Valor inválido";
            }
            return retorno;
        }


        /// <summary>
        /// Convierte el numero ingresado de decimal a binario
        /// </summary>
        /// <param name="numero"> numero a convertir </param>
        /// <returns> retorna el numero en formato binario o en caso de error retornara "Valor inválido" </returns>
        public static string DecimalBinario(string numero)
        {
            string retorno = string.Empty;
            double numeroDouble;
            if(double.TryParse(numero, out numeroDouble))
            {
                retorno = DecimalBinario(numeroDouble);
            }
            else
            {
                retorno = "Valor inválido"; 
            }
            return retorno;
        }


        /// <summary>
        /// Sobrecarga del operador + para sumar dos variables del tipo Operando
        /// </summary>
        /// <param name="n1"> primer variable a sumar </param>
        /// <param name="n2"> segunda variable a sumar </param>
        /// <returns> retorna el resultado de la suma de ambos numeros  </returns>
        public static double operator +(Operando n1, Operando n2)
        {
            double retorno = 0;

            retorno = n1.numero + n2.numero;

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del oprador - que opera dos varibles del tipo Operando
        /// </summary>
        /// <param name="n1"> primer variable a operar </param>
        /// <param name="n2"> segunda cariable a operar </param>
        /// <returns> retorna el resultado de la resta de ambos numeros </returns>
        public static double operator -(Operando n1, Operando n2)
        {
            double retorno = 0;

            retorno = n1.numero - n2.numero;

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador * que opera dos variables del tipo Operando
        /// </summary>
        /// <param name="n1"> primer variable a operar </param>
        /// <param name="n2"> segunda variable a operar </param>
        /// <returns> retorna el resultado de la multiplicacion de ambos numeros </returns>
        public static double operator *(Operando n1, Operando n2)
        {
            double retorno = 0;

            retorno = n1.numero * n2.numero;

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador / que opera dos variables del tipo Operando
        /// </summary>
        /// <param name="n1"> primer variable a operar </param>
        /// <param name="n2"> segunda variable a operar </param>
        /// <returns> retorna la division entre ambos numeros </returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno = 0;

            if(n1.numero != 0 || n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
            else
            {
                retorno = double.MinValue;
            }
            return retorno;
        }
    }
}
