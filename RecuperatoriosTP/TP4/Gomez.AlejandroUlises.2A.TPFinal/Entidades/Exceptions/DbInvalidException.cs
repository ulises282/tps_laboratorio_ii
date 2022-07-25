using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class DbInvalidException : Exception
    {
        public DbInvalidException(string message) : base(message)
        {

        }

        public DbInvalidException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
