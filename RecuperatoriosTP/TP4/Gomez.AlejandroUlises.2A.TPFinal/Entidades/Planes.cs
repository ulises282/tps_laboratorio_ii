using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planes
    {
        private int codigoPlan;
        private double precio;
        private int megas;
        private string nombre;

        public double Precio { get => precio; }
        public int Megas { get => megas; }
        public string Nombre { get => nombre; }
        public int CodigoPlan { get => codigoPlan; set => codigoPlan = value; }

        public Planes(int codigoPlan, double precio, int megas, string nombre) : this(precio, megas, nombre)
        {
            this.CodigoPlan = codigoPlan;
        }
        public Planes(double precio, int megas, string nombre)
        {
            this.precio = precio;
            this.megas = megas;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }

        public static List<Planes> Leer()
        {
            throw new NotImplementedException();
        }
    }
}
