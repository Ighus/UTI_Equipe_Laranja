using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTI_GrupoLaranja.BLL.Exceptions
{
    public class ExceptionPaciente : Exception
    {
        public ExceptionPaciente()
        {

        }

        public ExceptionPaciente(string message)
            : base(message)
        {

        }

        public ExceptionPaciente(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
