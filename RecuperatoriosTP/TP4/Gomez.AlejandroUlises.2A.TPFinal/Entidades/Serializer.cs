using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    class Serializer<T> : Archivos, IArchivos<T> where T : class, new()
    {
        public Serializer(ETipoArchivo tipo) : base(tipo)
        {

        }
        public void Escribir(string nombreDelArchivo, T elemento)
        {
            try
            {
                using (XmlTextWriter xmlTextWriter = new XmlTextWriter($"{ruta}\\{nombreDelArchivo}", Encoding.UTF8))
                {
                    xmlTextWriter.Formatting = Formatting.Indented;
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(xmlTextWriter, elemento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Serializar", ex);
            }
        }

        public T Leer(string nombreDelArchivo)
        {
            try
            {
                using (XmlTextReader xmlTextReader = new XmlTextReader($"{ruta}\\{nombreDelArchivo}"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return serializer.Deserialize(xmlTextReader) as T;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al DesSerializar", ex);
            }
        }
    }
}
