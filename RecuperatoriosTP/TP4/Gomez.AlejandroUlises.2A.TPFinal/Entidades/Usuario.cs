using System;

namespace Entidades
{
    public class Usuario
    {
        private string apellido;
        private string nombre;
        private string sexo;
        private int dni;
        private int codigoPlan;

        public string Apellido { get => apellido; }
        public string Nombre { get => nombre; }
        public string Sexo { get => sexo; }
        public int Dni { get => dni; }
        public int CodigoPlan { get => codigoPlan; set => codigoPlan = value; }

        public Usuario(string nombre, string apellido, string sexo, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.dni = dni;
        }

        public Usuario(string nombre, string apellido, string sexo, int dni,int codigoPlan) : this(nombre, apellido, sexo, dni)
        {
            this.CodigoPlan = codigoPlan;
        }
        
    }
}
