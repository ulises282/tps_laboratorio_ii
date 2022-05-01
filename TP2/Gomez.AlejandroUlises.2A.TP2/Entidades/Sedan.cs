using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        ETipo tipo;
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"> marca del vehiculo </param>
        /// <param name="chasis"> chasis del vehiculo </param>
        /// <param name="color"> color del vehiculo </param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
        }

        /// <summary>
        /// Cosntructor de la clase sedan 
        /// </summary>
        /// <param name="marca">marca del vehiculo</param>
        /// <param name="chasis"> chasis del vehiculo </param>
        /// <param name="color"> color del vehiculo </param>
        /// <param name="tipo"> tipo del vehiculo </param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis, marca,color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Muestra los datos del vehiculo del tipo Sedan
        /// </summary>
        /// <returns> retorna los datos del vehiculo de tipo sedan </returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(this.ToString());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
