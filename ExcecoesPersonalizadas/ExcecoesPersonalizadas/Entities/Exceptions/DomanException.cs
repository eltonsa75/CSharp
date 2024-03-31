using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesPersonalizadas.Entities.Exceptions
{
    internal class DomanException : ApplicationException

    {
        public DomanException(string message) : base(message)
        {

        }
    }
}
