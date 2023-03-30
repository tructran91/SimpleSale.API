using SimpleSale.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Application.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base(MessageConstant.NotFoundException) { }

        public NotFoundException(string message) : base(message) { }

        public NotFoundException(string message, Exception exception) : base(message, exception) { }
    }
}
