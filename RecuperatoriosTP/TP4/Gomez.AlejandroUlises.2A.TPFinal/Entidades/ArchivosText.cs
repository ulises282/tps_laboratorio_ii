using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ArchivosText : Archivos, IArchivos<string>
    {
        public ArchivosText() : base(ETipoArchivo.TXT)
        {

        }
        public void Escribir(string nombreDelArchivo, string elemento)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter($"{ruta}\\{nombreDelArchivo}"))
                {
                    streamWriter.WriteLine(elemento);
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error al escrivir en el archivo", exception);
            }
        }

        public string Leer(string nombreDelArchivo)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader($"{ruta}\\{nombreDelArchivo}"))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error al escrivir en el archivo", exception);
            }
        }
    }
}
