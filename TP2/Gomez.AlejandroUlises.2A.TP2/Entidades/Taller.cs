using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Taller
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        #region "Constructores"
        /// <summary>
        ///  Constructor de la clase Taller donde se inicializa la lista.
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Constructor de la clase taller donde se ingresa espacio disponible 
        /// </summary>
        /// <param name="espacioDisponible"> cantidad de espacio disponible en el taller </param>
        public Taller(int espacioDisponible):this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns> Muestra el estacionamiento y sus vehiculos </returns>
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Estacionamiento: ");
            s.AppendLine(this.Listar(this, ETipo.Todos));

            return s.ToString();
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns> retorna los datos de los elementos que coincidan con el parametro ingresado </returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine($"\nTipo de vehiculos: {tipo}");
            sb.AppendLine("---------------------");            
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Ciclomotor:
                        if(v.GetType().Name == tipo.ToString())
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if(v.GetType().Name == tipo.ToString())
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.SUV:
                        if (v.GetType().Name == "Suv")
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }
            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns> retorna la lista con el nuevo elemento ingresado(solo si se pudo) </returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            bool flag = false;
            if(taller.espacioDisponible > 0)
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    taller.vehiculos.Add(vehiculo);
                    taller.espacioDisponible--;
                }
            }
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns> retorna la lista sin el elemento ingresado como parametro(solo si se pudo) </returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            bool flag = false;
            foreach (Vehiculo v in taller.vehiculos)
            {                
                if (v == vehiculo)
                {
                    flag = true;
                    break;
                }
            }
            if(flag == true)
            {
                taller.vehiculos.Remove(vehiculo);
                taller.espacioDisponible++;
            }
            return taller;
        }
        #endregion
    }
}
