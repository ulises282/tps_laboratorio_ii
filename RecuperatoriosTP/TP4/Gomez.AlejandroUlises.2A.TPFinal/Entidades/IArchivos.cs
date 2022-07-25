using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IArchivos<T> where T: class
    {
        T Leer(string nombreDelArchivo);

        void Escribir(string nombreDelArchivo, T elemento);
    }
}
