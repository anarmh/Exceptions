using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Exception
{
    public class BadRequestException:SystemException
    {
        public BadRequestException(string message) : base(message)
        {
        }
    }
}
