using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Archivos
    {
        protected string ruta;
        protected ETipoArchivo tipo;



        public Archivos(ETipoArchivo tipo)
        {
            DirectoryInfo path;
            if (tipo == ETipoArchivo.TXT)
            {
                path = Directory.CreateDirectory($"{Environment.CurrentDirectory}");
            }
            else
            {
                path = Directory.CreateDirectory($"{Environment.CurrentDirectory}\\ListaDePlanes\\");
            }
            ruta = path.FullName;
            this.tipo = tipo;
        }
        
    }
}
