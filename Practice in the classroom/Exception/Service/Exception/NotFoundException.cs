using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Exception
{
    public class NotFoundException:SystemException
    {
        public NotFoundException(string message) :base(message)
        {
        }
    }
}
