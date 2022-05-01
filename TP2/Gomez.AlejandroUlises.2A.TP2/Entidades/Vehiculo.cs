using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        EMarca marca;
        string chasis;
        ConsoleColor color;

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get;}

        /// <summary>
        /// Constructor de la clase vehiculo 
        /// </summary>
        /// <param name="chasis">chasis a settear</param>
        /// <param name="marca">marca a settear </param>
        /// <param name="color"> color a settear </param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }


        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns> Retorna los datos del vehiculo. </returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"chasis: {this.chasis}");
            sb.AppendLine($"marca: {this.marca}");
            sb.AppendLine($"color: {this.color}");

            return sb.ToString();
        }
        
        /// <summary>
        /// Sobrecarga del metodo string que muestra los datos de un vehiculo
        /// </summary>
        /// <param name="p"> veiculo a mostrar </param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(p.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"> vehiculo a comparar 1</param>
        /// <param name="v2"> vehiculo a comparar 2</param>
        /// <returns> retorna true en caso de ser iguales o false en caso contrario </returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            
            bool retorno = false;
            if(v1.chasis == v2.chasis)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"> 1 vehiculo a comparar </param>
        /// <param name="v2"> 2 vehiculo a comparar </param>
        /// <returns> true en caso de ser distintos o false caso contrario </returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (!(v1.chasis == v2.chasis));
        }
    }
}
