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

        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string strNumero)
        {
            double numero;
            if(double.TryParse(strNumero, out numero))
            {
                this.numero = double.Parse(strNumero);
            }
        }

        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;
            double.TryParse(strNumero, out retorno);
            return retorno;
        }

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

        public static double operator +(Operando n1, Operando n2)
        {
            double retorno = 0;

            retorno = n1.numero + n2.numero;

            return retorno;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            double retorno = 0;

            retorno = n1.numero - n2.numero;

            return retorno;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            double retorno = 0;

            retorno = n1.numero * n2.numero;

            return retorno;
        }
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
