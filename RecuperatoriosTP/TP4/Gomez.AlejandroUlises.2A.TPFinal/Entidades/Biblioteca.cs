using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private string apellido;
        private string nombre;
        private int dni;
        private string sexo;
        private double precio;
        private int megas;
        private string nombrePlan;

        public string Apellido { get => apellido; }
        public string Nombre { get => nombre; }
        public int Dni { get => dni; }
        public string Sexo { get => sexo; }
        public double Precio { get => precio; }
        public int Megas { get => megas; }
        public string NombrePlan { get => nombrePlan; }

        public Biblioteca(string apellido, string nombre, int dni, string sexo, double precio, int megas, string nombrePlan)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.sexo = sexo;
            this.precio = precio;
            this.megas = megas;
            this.nombrePlan = nombrePlan;
        }
    }
}
